using System;
using System.Collections;

namespace HashTable
{
    class KeyValuePair
    {
        public object Key { get; set; }
        public object Value { get; set; }
        public KeyValuePair(object key, object value)
        { 
            Key = key;
            Value = value;
        }
    }

    public class HashTable
    {
        readonly KeyValuePair[] KVP;
        readonly int size;
        /// <summary>
        /// Конструктор контейнера
        /// summary>
        /// size">Размер хэ-таблицы
        public HashTable(int size)
        {
            this.size = size;
            KVP = new KeyValuePair[size];
        }

        ///
        /// Метод складывающий пару ключь-значение в таблицу
        ///
        /// key">
        /// value">
        public void PutPair(object key, object value)
        {
            var hash = key.GetHashCode();
            var position = Math.Abs(hash) % size;
            for (; KVP[position] != null; position = (position+1)%size)
            {
                if (KVP[position].Key.Equals(key))
                    break;
            }
            KVP[position] = new KeyValuePair(key, value);
        }

        /// <summary>
        /// Поиск значения по ключу
        /// summary>
        /// key">Ключь
        /// <returns>Значение, null если ключ отсутствуетreturns>
        public object GetValueByKey(object key)
        {
            var hash = key.GetHashCode();
            var position = Math.Abs(hash) % size;
            for (; KVP[position] != null;)
            {
                if (KVP[position].Key.Equals(key))
                    return KVP[position].Value;
                else return null;
            }
            return null;
        }
    }
}
