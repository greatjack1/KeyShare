using LiteDB;
using System;

namespace KeyShare.Models
{
    public class LiteDbRepository : IRepository
    {
        private LiteDatabase mLiteDatabase;
        private LiteCollection<KeyEntry> mEntrys;
        public LiteDbRepository()
        {
            mLiteDatabase = new LiteDatabase("KeyShareStore.db");
            mEntrys = mLiteDatabase.GetCollection<KeyEntry>("KeyEntrys");
        }
        public void addKeyEntry(KeyEntry entry){
            //if it exists update the current entry otherwise create it
            var results = mEntrys.FindOne(x => (x.Key == entry.Key && x.Secret == entry.Secret));
            if (results != null)
            {
                results.Value = entry.Value;
                mEntrys.Update(results);
            }
            else { //add the key entry to the database
                mEntrys.Insert(entry);            }
        }
     /// <summary>
     /// A method to retreive a value given the key and secret
     /// </summary>
     /// <param name="Key"></param>
     /// <param name="secret"></param>
     /// <returns>The value for the given key and secret, if it doesnt exists returns NA</returns>
        public string getValue(string Key,string Secret){
            var results = mEntrys.FindOne(x => (x.Key == Key && x.Secret == Secret));
            return (results != null) ? results.Value : "NA";
        }
    }
}
