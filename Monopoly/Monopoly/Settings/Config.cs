using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Settings
{
    public static class Config
    {
        public const string filePath_XmlBoard = "../../Resources/XML/XMLBoardCell.xml";
        public const string filePath_XmlBank = "../../Resources/XML/XMLBank.xml";
        public const string filePath_XmlCommunityCard = "../../Resources/XML/XMLCommunityCard.xml";
        public const string filePath_XmlChanceCard = "../../Resources/XML/XMLChanceCard.xml";

        public static int NUMBER_OF_HOTEL = 16;
        public static int NUMBER_OF_HOUSE = 32;
    }
}
