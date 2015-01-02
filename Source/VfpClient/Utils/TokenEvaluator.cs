using System;

namespace VfpClient.Utils {
    internal static partial class CommandTextParser {
        internal class TokenEvaluator {
            private readonly ITokenHandler _tokenHandler;

            public TokenEvaluator(ITokenHandler tokenHandler) {
                if (tokenHandler == null) {
                    throw new ArgumentNullException("tokenHandler");
                }

                _tokenHandler = tokenHandler;
            }

            internal void Evaluate(string source) {
                var currentIndex = 0;
                var token = string.Empty;
                var tokenIsQuote = false;

                while (currentIndex < source.Length) {
                    var character = source[currentIndex++];

                    if (!tokenIsQuote && char.IsWhiteSpace(character)) {
                        if (_tokenHandler.IsValid(token)) {
                            token = string.Empty;
                            continue;
                        }

                        _tokenHandler.Add(token);
                        token = string.Empty;
                        continue;
                    }

                    token += character;

                    tokenIsQuote = GetTokenIsQuote(tokenIsQuote, character);
                }

                if (!string.IsNullOrEmpty(token)) {
                    _tokenHandler.Add(token);
                }
            }

            private static bool GetTokenIsQuote(bool tokenIsQuote, char character) {
                if (tokenIsQuote) {
                    if (IsCloseQuoteCharacter(character)) {
                        return false;
                    }
                }
                else {
                    if (IsOpenQuoteCharacter(character)) {
                        return true;
                    }
                }

                return tokenIsQuote;
            }

            private static bool IsOpenQuoteCharacter(char character) {
                switch (character) {
                    case '"':
                    case '\'':
                    case '[':
                        return true;
                    default:
                        return false;
                }
            }

            private static bool IsCloseQuoteCharacter(char character) {
                switch (character) {
                    case '"':
                    case '\'':
                    case ']':
                        return true;
                    default:
                        return false;
                }
            }
        }
    }
}