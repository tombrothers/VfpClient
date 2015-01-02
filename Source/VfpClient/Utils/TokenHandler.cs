using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace VfpClient.Utils {
    internal static partial class CommandTextParser {
        internal class TokenHandler : ITokenHandler {
            private readonly List<string> _items = new List<string>();

            public ReadOnlyCollection<string> Items {
                get { return _items.AsReadOnly(); }
            }

            public string Type { get; private set; }

            public TokenHandler(string type) {
                if (string.IsNullOrEmpty(type)) {
                    throw new ArgumentNullException("type");
                }

                Type = type;
            }

            public bool IsValid(string token) {
                return !string.IsNullOrEmpty(token) && token.Equals(Type, StringComparison.InvariantCultureIgnoreCase);
            }

            public void Add(string token) {
                _items.Add(token);
            }

            public override string ToString() {
                return Type + " " + string.Join(" ", _items.ToArray());
            }
        }
    }
}