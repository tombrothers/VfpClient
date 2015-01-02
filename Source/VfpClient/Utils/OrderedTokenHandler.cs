using System;
using System.Collections.Generic;
using System.Linq;

namespace VfpClient.Utils {
    internal static partial class CommandTextParser {
        internal class OrderedTokenHandler : ITokenHandler {
            public string Type {
                get { return GetType().ToString(); }
            }

            private readonly Queue<ITokenHandler> _tokenHandlers;
            private ITokenHandler _tokenHandler;

            public OrderedTokenHandler(IEnumerable<ITokenHandler> tokenHandlers) {
                if (tokenHandlers == null) {
                    throw new ArgumentNullException("tokenHandlers");
                }

                _tokenHandlers = new Queue<ITokenHandler>();

                foreach (var token in tokenHandlers) {
                    _tokenHandlers.Enqueue(token);
                }
            }

            public bool IsValid(string token) {
                if (!_tokenHandlers.Any()) {
                    return false;
                }

                var currentToken = _tokenHandlers.Peek();

                if (currentToken == null || !currentToken.IsValid(token)) {
                    return false;
                }

                _tokenHandler = _tokenHandlers.Dequeue();

                return true;
            }

            public void Add(string token) {
                if (_tokenHandler != null) {
                    _tokenHandler.Add(token);
                }
            }
        }
    }
}