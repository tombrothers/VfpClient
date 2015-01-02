using System;
using System.Collections.Generic;
using System.Linq;

namespace VfpClient.Utils {
    internal static partial class CommandTextParser {
        internal class UnOrderedTokenHandler : ITokenHandler {
            public string Type {
                get { return GetType().ToString(); }
            }

            private readonly IEnumerable<ITokenHandler> _tokenHandlers;
            private ITokenHandler _tokenHandler;

            public UnOrderedTokenHandler(IEnumerable<ITokenHandler> tokenHandlers) {
                if (tokenHandlers == null) {
                    throw new ArgumentNullException("tokenHandlers");
                }

                _tokenHandlers = tokenHandlers;
            }

            public bool IsValid(string token) {
                _tokenHandler = _tokenHandlers.FirstOrDefault(x => x.IsValid(token));

                return _tokenHandler != null;
            }

            public void Add(string token) {
                if (_tokenHandler != null) {
                    _tokenHandler.Add(token);
                }
            }
        }
    }
}