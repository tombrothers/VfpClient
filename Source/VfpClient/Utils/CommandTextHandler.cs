using System.Collections.Generic;

namespace VfpClient.Utils {
    internal static partial class CommandTextParser {
        internal class CommandTextHandler : ITokenHandler {
            public string Type {
                get { return GetType().ToString(); }
            }

            public ITokenHandler Command { get; private set; }
            public TokenHandler From { get; private set; }
            private readonly ITokenHandler _tokenHandler;

            public CommandTextHandler() {
                Command = CreateCommandTokenHandler();
                From = new TokenHandler("From");
                _tokenHandler = GetTokenHandler();
            }

            public bool IsValid(string token) {
                return _tokenHandler.IsValid(token);
            }

            public void Add(string token) {
                _tokenHandler.Add(token);
            }

            private ITokenHandler GetTokenHandler() {
                return new OrderedTokenHandler(new List<ITokenHandler> {
                                                   Command, 
                                                   From, 
                                                   new UnOrderedTokenHandler(GetOptionalTokenHandlers())
                                               });
            }

            private static IEnumerable<ITokenHandler> GetOptionalTokenHandlers() {
                yield return new TokenHandler("Where");
                yield return new TokenHandler("Order");
                yield return new TokenHandler("Inner");
                yield return new TokenHandler("Outer");
                yield return new TokenHandler("Union");
                yield return new TokenHandler("Join");
            }

            private static ITokenHandler CreateCommandTokenHandler() {
                return new FirstValidTokenHandler(new List<ITokenHandler> {
                                                    new TokenHandler("Select"),
                                                    new TokenHandler("Delete"),
                                                    new TokenHandler("Update"),
                                                    new TokenHandler("Insert")
                                                });
            }
        }
    }
}