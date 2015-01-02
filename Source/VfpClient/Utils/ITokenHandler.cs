namespace VfpClient.Utils {
    internal static partial class CommandTextParser {
        internal interface ITokenHandler {
            bool IsValid(string token);
            void Add(string token);
            string Type { get; }
        }
    }
}