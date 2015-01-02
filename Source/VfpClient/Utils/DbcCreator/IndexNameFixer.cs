using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace VfpClient.Utils.DbcCreator {
    internal static class IndexNameFixer {
        public static void Evaluate(IEnumerable<Index> indexes) {
            ArgumentUtility.CheckNotNull("indexes", indexes);

            if (!indexes.Any()) {
                return;
            }

            FixNameLength(indexes);
            FixNonUniqueIndexNames(indexes);
        }

        private static void FixNonUniqueIndexNames(IEnumerable<Index> indexes) {
            var indexQuery = indexes.GroupBy(x => x.Name, x => x).ToList();

            while (indexQuery.Any(x => x.Count() > 1)) {
                foreach (var indexGroup in indexQuery.Where(x => x.Count() > 1)) {
                    var counter = -1;

                    foreach (var indexItem in indexGroup) {
                        counter++;

                        // Don't rename the first item.
                        if (counter == 0) {
                            continue;
                        }

                        while (true) {
                            var number = counter.ToString(CultureInfo.InvariantCulture);
                            var newName = indexItem.Name;

                            if (newName.Length + number.Length > VfpMapping.MaximumIndexNameLength) {
                                newName = newName.Substring(0, VfpMapping.MaximumIndexNameLength - number.Length);
                            }

                            newName = newName + number;

                            if (!indexes.Any(x => x.Name == newName)) {
                                indexItem.Name = newName;
                                break;
                            }

                            counter++;
                        }
                    }
                }
            }
        }

        private static void FixNameLength(IEnumerable<Index> indexes) {
            foreach (var index in indexes) {
                if (string.IsNullOrEmpty(index.Name)) {
                    index.Name = "Index";
                }

                if (index.Name.Length > VfpMapping.MaximumIndexNameLength) {
                    index.Name = index.Name.Substring(0, VfpMapping.MaximumIndexNameLength);
                }
            }
        }
    }
}