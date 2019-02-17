using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Yudan
{
    internal class Hashing
        {
            internal enum HashTypes
            {
                Md5,
                Sha1,
                Sha256,
                Sha384,
                Sha512
            }
    
            public static string HashString(string content, HashTypes hashtype = HashTypes.Md5)
            {
                try
                {
                    switch (hashtype)
                    {
                        case HashTypes.Md5:
                            using (var md = MD5.Create())
                            {
                                var comp = md.ComputeHash(Encoding.UTF8.GetBytes(content));
                                StringBuilder hash = new StringBuilder();
                                foreach (byte b in comp)
                                {
                                    hash.Append(b.ToString("X2"));
                                }
    
                                return hash.ToString();
                            }
    
                        case HashTypes.Sha1:
                            using (SHA1Managed sha = new SHA1Managed())
                            {
                                var comp = sha.ComputeHash(Encoding.UTF8.GetBytes(content));
                                var hash = new StringBuilder(comp.Length * 2);
                                foreach (byte b in comp)
                                {
                                    hash.Append(b.ToString("X2"));
                                }
    
                                return hash.ToString();
                            }
                        case HashTypes.Sha256:
                            using (SHA256Managed sha = new SHA256Managed())
                            {
                                var comp = sha.ComputeHash(Encoding.UTF8.GetBytes(content));
                                var hash = new StringBuilder(comp.Length * 2);
                                foreach (byte b in comp)
                                {
                                    hash.Append(b.ToString("X2"));
                                }
    
                                return hash.ToString();
                            }
                        case HashTypes.Sha384:
                        {
                            using (SHA384Managed sha = new SHA384Managed())
                            {
                                var comp = sha.ComputeHash(Encoding.UTF8.GetBytes(content));
                                var hash = new StringBuilder(comp.Length * 2);
                                foreach (byte b in comp)
                                {
                                    hash.Append(b.ToString("X2"));
                                }
    
                                return hash.ToString();
                            }
                        }
                        case HashTypes.Sha512:
                            using (SHA512Managed sha = new SHA512Managed())
                            {
                                var comp = sha.ComputeHash(Encoding.UTF8.GetBytes(content));
                                var hash = new StringBuilder(comp.Length * 2);
                                foreach (byte b in comp)
                                {
                                    hash.Append(b.ToString("X2"));
                                }
    
                                return hash.ToString();
                            }
                        default:
                            return "hashError";
                    }
                }
                catch (Exception)
                {
                    return "hashError";
                }
            }
    
            public static string HashFile(string filepath, HashTypes hashtype = HashTypes.Md5)
            {
                if (File.Exists(filepath))
                {
                    try
                    {
                        using (FileStream fs = new FileStream(filepath, FileMode.Open))
                        using (BufferedStream bs = new BufferedStream(fs))
                        {
                            switch (hashtype)
                            {
                                case HashTypes.Md5:
                                    using (var md = MD5.Create())
                                    {
                                        var comp = md.ComputeHash(bs);
                                        var hash = new StringBuilder();
                                        foreach (byte b in comp)
                                        {
                                            hash.Append(b.ToString("X2"));
                                        }
    
                                        return hash.ToString();
                                    }
                                case HashTypes.Sha1:
                                    using (SHA1Managed sha = new SHA1Managed())
                                    {
                                        var comp = sha.ComputeHash(bs);
                                        var hash = new StringBuilder(comp.Length * 2);
                                        foreach (byte b in comp)
                                        {
                                            hash.Append(b.ToString("X2"));
                                        }
    
                                        return hash.ToString();
                                    }
                                case HashTypes.Sha256:
                                    using (SHA256Managed sha = new SHA256Managed())
                                    {
                                        var comp = sha.ComputeHash(bs);
                                        var hash = new StringBuilder(comp.Length * 2);
                                        foreach (byte b in comp)
                                        {
                                            hash.Append(b.ToString("X2"));
                                        }
    
                                        return hash.ToString();
                                    }
                                case HashTypes.Sha384:
                                    using (SHA384Managed sha = new SHA384Managed())
                                    {
                                        var comp = sha.ComputeHash(bs);
                                        var hash = new StringBuilder(comp.Length * 2);
                                        foreach (byte b in comp)
                                        {
                                            hash.Append(b.ToString("X2"));
                                        }
    
                                        return hash.ToString();
                                    }
                                case HashTypes.Sha512:
                                    using (SHA512Managed sha = new SHA512Managed())
                                    {
                                        var comp = sha.ComputeHash(bs);
                                        var hash = new StringBuilder(comp.Length * 2);
                                        foreach (byte b in comp)
                                        {
                                            hash.Append(b.ToString("X2"));
                                        }
    
                                        return hash.ToString();
                                    }
                                default:
                                    return "hashError";
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return "hashError";
                    }
                }
                return "fileNotFound";
            }
        }
}