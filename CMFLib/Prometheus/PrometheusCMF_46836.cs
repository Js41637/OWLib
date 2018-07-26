﻿using static CMFLib.CMFHandler;

namespace CMFLib.Prometheus {
    [CMFMetadata(AutoDetectVersion = true, BuildVersions = new uint[] { }, App = CMFApplication.Prometheus)]
    public class PrometheusCMF_46836 : ICMFProvider {
        public byte[] Key(CMFHeaderCommon header, string name, byte[] digest, int length) {
            byte[] buffer = new byte[length];

            uint kidx = Keytable[header.DataCount & 511];
            uint increment = kidx % 61;
            for (int i = 0; i != length; ++i)
            {
                buffer[i] = Keytable[SignedMod(kidx, 512)];
                kidx += increment;
            }

            return buffer;
        }

        public byte[] IV(CMFHeaderCommon header, string name, byte[] digest, int length) {
            byte[] buffer = new byte[length];

            uint kidx = (uint)(digest[7] + (ushort) header.DataCount) & 511;
            uint increment = header.EntryCount + digest[SignedMod(header.EntryCount, SHA1_DIGESTSIZE)];
            for (int i = 0; i != length; ++i)
            {
                buffer[i] = Keytable[SignedMod(kidx, 512)];
                kidx += increment;
                buffer[i] ^= digest[SignedMod(header.BuildVersion + i, SHA1_DIGESTSIZE)];
            }

            return buffer;
        }

        private static readonly byte[] Keytable = {
            0x08, 0xAC, 0x86, 0x79, 0x40, 0xB6, 0xA1, 0xC1, 0xD3, 0x5B, 0x35, 0x1A, 0xDD, 0x4A, 0x34, 0x22, 
            0x38, 0x1A, 0x8B, 0x09, 0x64, 0xB9, 0x1D, 0x7B, 0xD8, 0xA8, 0x06, 0x1E, 0x91, 0xC7, 0x6F, 0xEA, 
            0x84, 0x6E, 0x51, 0x79, 0x39, 0xCF, 0xE6, 0x61, 0x7A, 0x14, 0xEA, 0x47, 0x0D, 0x0F, 0xAA, 0x62, 
            0x15, 0x2C, 0x42, 0xFE, 0x68, 0x7C, 0x7E, 0x87, 0xD2, 0xFD, 0x91, 0x68, 0xFF, 0x85, 0xC0, 0xEC, 
            0x9F, 0xDE, 0x88, 0x44, 0xFB, 0x52, 0x67, 0xA5, 0xC7, 0x3F, 0x6C, 0xA4, 0x59, 0x83, 0x82, 0x3B, 
            0x1D, 0x96, 0xC7, 0xF0, 0x58, 0x8A, 0xA5, 0x57, 0xD7, 0x44, 0x7E, 0x7D, 0x5D, 0x4E, 0x21, 0x52, 
            0x53, 0x5C, 0xCA, 0x4E, 0x5A, 0x1B, 0xBF, 0x7F, 0x59, 0x55, 0x08, 0xFE, 0xE5, 0x55, 0x7B, 0x22, 
            0xAD, 0xC2, 0x22, 0x0A, 0x3D, 0xC5, 0x91, 0xA4, 0x30, 0xCF, 0xA7, 0xC0, 0x2E, 0x79, 0x9B, 0x80, 
            0x86, 0xF1, 0xC5, 0xFC, 0xFD, 0xAE, 0x8E, 0x3A, 0x80, 0x5C, 0x9F, 0x60, 0xB7, 0x66, 0x14, 0x11, 
            0x4A, 0xF9, 0x0D, 0x72, 0x76, 0xC7, 0x35, 0xCC, 0xCC, 0x76, 0x11, 0x0C, 0x69, 0xED, 0xE6, 0xC8, 
            0x4F, 0xBE, 0x9C, 0x47, 0x62, 0x7E, 0x1E, 0x34, 0x95, 0xE8, 0x52, 0xF6, 0x09, 0x91, 0xE3, 0x3E, 
            0xB5, 0x43, 0x43, 0xFF, 0xB0, 0x17, 0xEA, 0x24, 0xF7, 0xEA, 0xF9, 0x66, 0x56, 0x25, 0x72, 0x2B, 
            0x49, 0x30, 0x23, 0xCE, 0x4E, 0x37, 0x75, 0x52, 0xE9, 0x4F, 0x29, 0x05, 0xFD, 0x6F, 0x90, 0x55, 
            0x9E, 0x62, 0xD4, 0x0C, 0x81, 0xF7, 0xE1, 0x30, 0x49, 0xF1, 0x48, 0xC3, 0xEB, 0x01, 0x9F, 0x3E, 
            0x24, 0x8C, 0x56, 0x21, 0xB1, 0x74, 0x58, 0xD2, 0xC2, 0xD3, 0xA4, 0xC2, 0x25, 0xBF, 0x7B, 0x0D, 
            0x39, 0x43, 0x3E, 0x0F, 0x70, 0x88, 0x13, 0x13, 0x75, 0xB5, 0x28, 0x92, 0x80, 0x5A, 0x13, 0x1D, 
            0x7D, 0xEC, 0x1B, 0x9B, 0x8F, 0x80, 0xF5, 0xFA, 0x20, 0xCA, 0x55, 0x40, 0x0B, 0xBB, 0x3D, 0xE0, 
            0xAB, 0xEF, 0x25, 0x8E, 0xF7, 0x08, 0x2F, 0x9C, 0x7C, 0x3A, 0xD8, 0x8E, 0xDD, 0x05, 0xE8, 0x72, 
            0x48, 0x96, 0xED, 0xA8, 0x05, 0x4B, 0x70, 0x07, 0x51, 0x7D, 0x77, 0x63, 0x3F, 0xA0, 0x47, 0x98, 
            0x0F, 0x07, 0xA5, 0x9A, 0x61, 0x11, 0x83, 0x64, 0xF9, 0x2B, 0x43, 0xA4, 0x68, 0x88, 0x55, 0xFE, 
            0xD0, 0x26, 0xCE, 0xAA, 0xD9, 0xDA, 0x58, 0xB7, 0xC7, 0x52, 0xBF, 0x33, 0x94, 0x6A, 0x86, 0x60, 
            0x9E, 0xD1, 0xB6, 0x57, 0x2C, 0x51, 0xB5, 0xB0, 0x95, 0x72, 0xE5, 0x15, 0xC6, 0x15, 0xC4, 0xF8, 
            0xDF, 0xF3, 0x47, 0x79, 0xC7, 0xC2, 0xE1, 0x42, 0xEA, 0x58, 0x67, 0xEB, 0xFA, 0x01, 0xBA, 0x10, 
            0xF6, 0x77, 0xC3, 0x52, 0x5B, 0x6F, 0xC8, 0xFA, 0xEF, 0x3D, 0xAF, 0x05, 0x99, 0x6A, 0x3A, 0xB8, 
            0x52, 0x00, 0x7E, 0x44, 0x24, 0x3A, 0xF0, 0xA1, 0x37, 0xB5, 0xC1, 0xC8, 0x8B, 0x1D, 0x29, 0x27, 
            0x62, 0x73, 0x64, 0x91, 0xEF, 0x59, 0x11, 0x18, 0x62, 0xDC, 0x88, 0x43, 0x79, 0xFC, 0xCD, 0x88, 
            0x6E, 0x01, 0xAE, 0x80, 0x5A, 0xBB, 0xB4, 0xA1, 0x41, 0x59, 0xFD, 0xA9, 0x44, 0x57, 0xA7, 0xD1, 
            0x22, 0xB6, 0xB7, 0x21, 0xF7, 0xEE, 0x6E, 0x9F, 0x29, 0x6C, 0x96, 0x6D, 0xDF, 0x3D, 0xC5, 0x4C, 
            0x90, 0x85, 0x2C, 0xF2, 0x85, 0x90, 0x0D, 0x9F, 0x69, 0xF9, 0x08, 0x85, 0xD8, 0x41, 0x88, 0xF8, 
            0x7F, 0xF1, 0x7C, 0x5E, 0xDA, 0xDD, 0xE7, 0xC0, 0xCE, 0x38, 0x0F, 0x83, 0x28, 0x1E, 0x7C, 0x55, 
            0xF3, 0x55, 0x7A, 0x2F, 0x15, 0x8D, 0xCE, 0x0B, 0x91, 0xF1, 0x0A, 0xBD, 0x69, 0x2B, 0x3D, 0xE0, 
            0x77, 0xAB, 0x03, 0x0D, 0x99, 0xC8, 0xD5, 0xA3, 0xD8, 0x95, 0x47, 0xB9, 0xA3, 0x65, 0x21, 0xB9
        };
    }
}