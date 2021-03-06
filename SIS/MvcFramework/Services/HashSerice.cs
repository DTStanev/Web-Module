﻿namespace MvcFramework.Services
{
    using Contracts;
    using MvcFramework.Logger.Contracts;
    using System;
    using System.Security.Cryptography;
    using System.Text;

    public class HashSerice :IHashService
    {
        private readonly ILogger logger;

        public HashSerice(ILogger logger)
        {
            this.logger = logger;
        }

        public string StrongHash(string stringToHash)
        {
            var result = stringToHash;
            for (int i = 0; i < 10; i++)
            {
                result = Hash(result);
            }

            return result;
        }

        public string Hash(string stringToHash)
        {
            stringToHash = stringToHash + "myAppSalt1316387123718#";
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(stringToHash));
                // Get the hashed string.  
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                this.logger.Log(hash);

                return hash;
            }
        }
    }
}