using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sayim
{
    public class Warehouses : IList
    {
        private ArrayList list;

        public Warehouses()
        {
            Clear();
            Add(new Warehouse("1010", "Acik Alan Ham."));
            Add(new Warehouse("1020", "DriveIn Alt Urun"));
            Add(new Warehouse("1030", "DriveIn Ust Urun"));
            Add(new Warehouse("1040", "Levha Dep.-Yan"));
            Add(new Warehouse("1050", "Levha Dep.- Arka"));
            Add(new Warehouse("1060", "Compound Deposu"));
            Add(new Warehouse("1070", "Y.mamul Folyo"));
            Add(new Warehouse("1080", "Yardimci Malz."));
            Add(new Warehouse("1090", "Teknik Malzeme"));
            Add(new Warehouse("1110", "Omsan Lojistik"));
            Add(new Warehouse("1111", "Horoz-Cayirova"));
            Add(new Warehouse("1112", "Horoz-Sekerpinar"));
            Add(new Warehouse("1120", "Ace-Merkez"));
            Add(new Warehouse("1121", "Ace-Kuruogullari"));
            Add(new Warehouse("1122", "Ace-Antrepo"));
            Add(new Warehouse("1200", "Uretim Koltuk."));
            Add(new Warehouse("1300", "Fason Deposu"));
            Add(new Warehouse("1400", "Blokaj Deposu"));
            Add(new Warehouse("1500", "Numune Deposu"));
            Add(new Warehouse("1600", "Sayim Deposu"));
        }

        #region IList Members

        public int Add(Warehouse value)
        {
            list.Add(value);
            return list.Count - 1;
        }

        public void Clear()
        {
            list = new ArrayList();
        }

        public bool Contains(object value)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int IndexOf(object value)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Insert(int index, object value)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public bool IsFixedSize
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public bool IsReadOnly
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public void Remove(object value)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void RemoveAt(int index)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public Warehouse this[int index]
        {
            get
            {
                return (Warehouse)list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        #endregion

        #region ICollection Members

        public void CopyTo(Array array, int index)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsSynchronized
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public object SyncRoot
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region IList Members

        int IList.Add(object value)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void IList.Clear()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        bool IList.Contains(object value)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        int IList.IndexOf(object value)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void IList.Insert(int index, object value)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        bool IList.IsFixedSize
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        bool IList.IsReadOnly
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        void IList.Remove(object value)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void IList.RemoveAt(int index)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        object IList.this[int index]
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        #endregion

        #region ICollection Members

        void ICollection.CopyTo(Array array, int index)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        int ICollection.Count
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        bool ICollection.IsSynchronized
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        object ICollection.SyncRoot
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
