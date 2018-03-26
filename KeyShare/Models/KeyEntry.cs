using System;
namespace KeyShare.Models
{
    /**
     * A simple poco class to represent a key entry in the database
     */
    public class KeyEntry
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Secret { get; set; }
    }
}
