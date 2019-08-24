﻿using CodeRunner.Packagings;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CodeRunner.IO
{
    public class PackageFileLoader<T> : ObjectFileLoader<Package<T>> where T : class
    {
        public PackageFileLoader(FileInfo file) : base(file)
        {
        }

        protected override async Task<Package<T>?> OnLoading()
        {
            try
            {
                using FileStream st = File.OpenRead();
                return await Package.Load<T>(st);
            }
            catch
            {
                return null;
            }
        }

        public override async Task Save(Package<T> value)
        {
            using FileStream st = File.Open(FileMode.Create, FileAccess.Write);
            await value.Save(st);
            File.LastWriteTime = DateTime.Now;
        }
    }
}