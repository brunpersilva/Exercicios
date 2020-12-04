using System;

namespace InternetFile
{
    class FileData 
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public FileData(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is FileData))
            {
                return false;
            }
            FileData other = obj as FileData;
            return Name.Equals(other.Name);
        }
        //public override string ToString()
        //{
        //    return Name + ", " + Date.ToString();
        //}

        
    }
}
