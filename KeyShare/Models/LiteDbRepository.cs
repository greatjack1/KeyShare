using System;

namespace KeyShare.Models
{
    public class LiteDbRepository : IRepository
    {
        private LiteDatabase mLiteDatabase;
        public LiteDbRepository()
        {
            mLiteDatabase = new LiteDatabase();   
        }
        public void addKeyEntry(KeyEntry entry){
            
        }
        public string getValue(string Key,string secret){
            
        }
    }
}
