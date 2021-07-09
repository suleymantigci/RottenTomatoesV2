using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RottenTomatoes.Entities
{
    public sealed class SearchText
    {
        private static SearchText instance = null;
        private static readonly object locker = new object();
        private Queue<string> listQueue = new Queue<string>(5);
        public SearchText()
        {
        }

        public static SearchText Instance
        {
            get
            {
                lock (locker)
                {
                    return instance ?? (instance = new SearchText());
                }
            }
        }

        public void AddList(string search)
        {
            if (this.listQueue.Count >= 5)
            {
                listQueue.Dequeue();
            }
            if(!listQueue.Contains(search)) listQueue.Enqueue(search);
        }

        public List<String> GetList()
        {
            return listQueue.Reverse().ToList();
        }
    }
}
