using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Monopoly.Handler.Service
{
    public static class XmlDataAccess
    {

        public static List<T> XMLDeserialize<T>(string pFilePath)
        {
            List<T> ListOfObjects = new List<T>();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlReaderSettings settings = new XmlReaderSettings { ConformanceLevel = ConformanceLevel.Fragment };
                using (StreamReader streamReader = new StreamReader(pFilePath))
                {
                    using (XmlReader xmlReader = XmlReader.Create(streamReader, settings))
                    {
                        while(xmlReader.Read())
                        {
                            if(xmlReader.NodeType == XmlNodeType.Element)
                            {
                                using (XmlReader subReader = xmlReader.ReadSubtree())
                                {
                                    T myObject = (T)serializer.Deserialize(subReader);
                                    ListOfObjects.Add(myObject);
                                }
                            }
                        }
                    }
                }
            }
            catch(InvalidOperationException expOperation)
            {
                Console.WriteLine(string.Format("Erreur dans le fichier xml : {0}", expOperation.Message));
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            return ListOfObjects;
        }
    }
}
