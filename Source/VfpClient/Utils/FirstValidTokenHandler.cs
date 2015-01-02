using System;
using System.Collections.Generic;
using System.Linq;

namespace VfpClient.Utils {
    internal static partial class CommandTextParser {
        internal class FirstValidTokenHandler : ITokenHandler {
            public string Type {
                get { return _tokenHandler == null ? GetType().ToString() : _tokenHandler.Type; }
            }

            private readonly IEnumerable<ITokenHandler> _tokenHandlers;
            private ITokenHandler _tokenHandler;

            public FirstValidTokenHandler(IEnumerable<ITokenHandler> tokenHandlers) {
                if (tokenHandlers == null) {
                    throw new ArgumentNullException("tokenHandlers");
                }

                _tokenHandlers = tokenHandlers;
            }

            public bool IsValid(string token) {
                _tokenHandler = _tokenHandler ?? _tokenHandlers.FirstOrDefault(x => x.IsValid(token));

                return _tokenHandler != null && _tokenHandler.IsValid(token);
            }

            public void Add(string token) {
                if (_tokenHandler != null) {
                    _tokenHandler.Add(token);
                }
            }

            public override string ToString() {
                return _tokenHandler == null ? string.Empty : _tokenHandler.ToString();
            }
        }
    }
}