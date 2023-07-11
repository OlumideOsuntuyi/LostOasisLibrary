using System;

namespace LostOasisLibrary
{
    namespace Collections
    {
        /// <summary>
        /// Represents a generic list.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        public class List<T>
        {
            public int capacity;
            private T[] content = new T[0];

            /// <summary>
            /// Initializes a new instance of the <see cref="List{T}"/> class.
            /// </summary>
            public List()
            {
                this.capacity = 0;
                content = new T[capacity];
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="List{T}"/> class with the specified capacity.
            /// </summary>
            /// <param name="capacity">The initial capacity of the list.</param>
            public List(int capacity)
            {
                this.capacity = capacity;
                content = new T[capacity];
            }

            /// <summary>
            /// Gets or sets the element at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index of the element to get or set.</param>
            /// <returns>The element at the specified index.</returns>
            public T this[int index]
            {
                get
                {
                    if (index >= 0 && index < content.Length)
                    {
                        return content[index];
                    }
                    throw new IndexOutOfRangeException();
                }
                set
                {
                    if (index >= 0 && index < content.Length)
                    {
                        content[index] = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
            }

            /// <summary>
            /// Removes all elements from the list.
            /// </summary>
            public void Clear()
            {
                content = Array.Empty<T>();
            }

            /// <summary>
            /// Fills the list with the specified item for the given range.
            /// </summary>
            /// <param name="item">The item to fill the list with.</param>
            /// <param name="range">The number of elements to fill in the list.</param>
            public void Fill(T item, int range)
            {
                content = new T[range];
                Array.Fill(content, item);
            }

            /// <summary>
            /// Returns the index of the specified item in the list.
            /// </summary>
            /// <param name="item">The item to search for.</param>
            /// <returns>The index of the specified item.</returns>
            public int IndexOf(T item)
            {
                if (InRange(0))
                {
                    for (int i = 0; i < content.Length; i++)
                    {

                    }
                    throw new IndexOutOfRangeException();
                }
                throw new NullReferenceException();
            }

            /// <summary>
            /// Checks if the specified index is within the range of the list.
            /// </summary>
            /// <param name="index">The index to check.</param>
            /// <returns>True if the index is within the range; otherwise, false.</returns>
            public bool InRange(int index)
            {
                return index < content.Length;
            }
        }

        /// <summary>
        /// Represents a custom string class.
        /// </summary>
        public class String
        {
            public char[] content = new char[0];

            /// <summary>
            /// Initializes a new instance of the <see cref="String"/> class.
            /// </summary>
            /// <param name="value">The value to initialize the string with.</param>
            public String(string value)
            {

            }

            /// <summary>
            /// Concatenates two strings.
            /// </summary>
            /// <param name="str1">The first string.</param>
            /// <param name="str2">The second string.</param>
            /// <returns>A new string that is the result of the concatenation.</returns>
            public static String operator +(String str1, String str2)
            {
                string concatenated = new string(str1.content) + new string(str2.content);
                return new String(concatenated);
            }

            /// <summary>
            /// Concatenates a custom string with a regular string.
            /// </summary>
            /// <param name="left">The custom string.</param>
            /// <param name="right">The regular string.</param>
            /// <returns>A new string that is the result of the concatenation.</returns>
            public static String operator +(String left, string right)
            {
                string concatenated = new string(left.content) + right;
                return new String(concatenated);
            }

            /// <summary>
            /// Concatenates a regular string with a custom string.
            /// </summary>
            /// <param name="left">The regular string.</param>
            /// <param name="right">The custom string.</param>
            /// <returns>A new string that is the result of the concatenation.</returns>
            public static String operator +(string left, String right)
            {
                string concatenated = left + new string(right.content);
                return new String(concatenated);
            }

            /// <summary>
            /// Converts the custom string to its string representation.
            /// </summary>
            /// <returns>The string representation of the custom string.</returns>
            public override string ToString()
            {
                return new string(content);
            }

            /// <summary>
            /// Gets or sets the character at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index of the character.</param>
            /// <returns>The character at the specified index.</returns>
            public char this[int index]
            {
                get
                {
                    if (index >= 0 && index < content.Length)
                    {
                        return content[index];
                    }
                    throw new IndexOutOfRangeException();
                }
                set
                {
                    if (index >= 0 && index < content.Length)
                    {
                        content[index] = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
            }

            /// <summary>
            /// Gets or sets the value of the custom string.
            /// </summary>
            public string Value
            {
                get
                {
                    return new string(content);
                }
                set
                {
                    content = new String(value).ToCharArray();
                }
            }

            /// <summary>
            /// Gets the length of the custom string.
            /// </summary>
            public int Length => content.Length;

            /// <summary>
            /// Checks if the custom string is empty.
            /// </summary>
            /// <returns>True if the custom string is empty; otherwise, false.</returns>
            public bool IsEmpty() => content.Length is 0;

            /// <summary>
            /// Checks if the custom string contains the specified value.
            /// </summary>
            /// <param name="value">The value to search for.</param>
            /// <returns>True if the custom string contains the value; otherwise, false.</returns>
            public bool Contains(String value) => Value.Contains(value.Value);

            /// <summary>
            /// Converts the custom string to a character array.
            /// </summary>
            /// <returns>The character array representing the custom string.</returns>
            public char[] ToCharArray() => content;

            /// <summary>
            /// Fills the custom string with the specified character for the given length.
            /// </summary>
            /// <param name="value">The character to fill the custom string with.</param>
            /// <param name="length">The number of characters to fill in the custom string.</param>
            public void Fill(char value, int length)
            {
                content = new char[length];
                Array.Fill(content, value);
            }
        }
    }
}