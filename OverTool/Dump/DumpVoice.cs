﻿using System;
using System.Collections.Generic;
using System.IO;
using CASCExplorer;
using OWLib;
using OWLib.Types.STUD;

namespace OverTool {
  class DumpVoice : IOvertool {
    public string Help => "output [hero query]";
    public uint MinimumArgs => 1;
    public char Opt => 'v';
    public string Title => "Extract Voice";
    public ushort[] Track => new ushort[1] { 0x75 };

    public static void Save(string path, List<ulong> soundData, Dictionary<ulong, Record> map, CASCHandler handler, Dictionary<ulong, ulong> replace = null) {
      HashSet<ulong> done = new HashSet<ulong>();
      List<ulong> sounds = ExtractLogic.Sound.FlattenSounds(soundData, map, handler, replace);
      foreach(ulong key in sounds) {
        if(!done.Add(key)) {
          continue;
        }
        ulong typ = APM.keyToTypeID(key);
        string ext = "wem";
        if(typ == 0x043) {
          ext = "bnk";
        }
        if(typ == 0x0BB) {
          ext = "vid.wem";
        }
        if(typ == 0x03F) {
          ext = "sfx.wem";
        }
        string ooutputPath = $"{path}{APM.keyToIndexID(key):X12}";
        string outputPath = $"{path}{APM.keyToIndexID(key):X12}";
        int sigma = 0;
        while(File.Exists(outputPath + "." + ext)) {
          sigma++;
          outputPath = ooutputPath + $"_{sigma:X}";
        }
        outputPath += "." + ext;
        using(Stream soundStream = Util.OpenFile(map[key], handler)) {
          using(Stream outputStream = File.Open(outputPath, FileMode.Create)) {
            ExtractLogic.Sound.CopyBytes(soundStream, outputStream, (int)soundStream.Length);
            Console.Out.WriteLine("Wrote file {0}", outputPath);
          }
        }
      }
    }

    public void Parse(Dictionary<ushort, List<ulong>> track, Dictionary<ulong, Record> map, CASCHandler handler, string[] args) {
      string output = args[0];

      List<string> heroes = new List<string>();
      if(args.Length > 1) {
        heroes.AddRange(args[1].ToLowerInvariant().Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries));
      }
      bool heroAllWildcard = heroes.Count == 0 || heroes.Contains("*");

      List<ulong> masters = track[0x75];
      foreach(ulong masterKey in masters) {
        if(!map.ContainsKey(masterKey)) {
          continue;
        }
        STUD masterStud = new STUD(Util.OpenFile(map[masterKey], handler));
        if(masterStud.Instances == null || masterStud.Instances[0] == null) {
          continue;
        }
        HeroMaster master = (HeroMaster)masterStud.Instances[0];
        if(master == null) {
          continue;
        }
        string heroName = Util.GetString(master.Header.name.key, map, handler);
        if(heroName == null) {
          continue;
        }
        if(!heroes.Contains(heroName.ToLowerInvariant())) {
          if(!heroAllWildcard) {
            continue;
          }
        }
        Console.Out.WriteLine("Dumping voice bites for hero {0}", heroName);
        List<ulong> soundData = ExtractLogic.Sound.FindSounds(master, track, map, handler);
        string path = string.Format("{0}{1}{2}{1}{3}{1}", output, Path.DirectorySeparatorChar, Util.Strip(Util.SanitizePath(heroName)), "Sound Dump");
        if(!Directory.Exists(path)) {
          Directory.CreateDirectory(path);
        }

        Save(path, soundData, map, handler);
      }
    }
  }
}