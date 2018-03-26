using System;
namespace KeyShare.Models
{
    public interface IRepository
    {
        void addKeyEntry(KeyEntry entry);
        string getValue(string key, string secret);
    }
}
