using SAT.CFDI._3._3;
using SAT.CFDI.ComercioExterior._1._1;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace SAT.Common
{
    public class Common
    {
        public static void Timbrar(Pac pac,bool Produccion,string FileName,string Usuario,string Pass)
        {
            try
            {
                switch (pac)
                {
                    case Pac.SolucionFactible:
                        byte[] bytes = Encoding.UTF8.GetBytes(File.ReadAllText(FileName));
                        SolucionFactible.TimbradoPortTypeClient portClient = null;
                        portClient = new SolucionFactible.TimbradoPortTypeClient((Produccion)? "TimbradoEndpoint_PRODUCCION": "TimbradoEndpoint_TESTING");
                        SolucionFactible.CFDICertificacion r = portClient.timbrar(Usuario, Pass, bytes, false);
                        SolucionFactible.CFDIResultadoCertificacion[] rs = r.resultados;
                        break;
                }
            }
            catch (Exception ex)
            {

            }

        }

        private static string GetPrefix(Tipo t)
        {
            string Prefix;
            switch (t)
                {
                    case Tipo.CatalogoCuentas_1_1:
                        Prefix = "catalogocuentas";
                        break;
                    case Tipo.BalanzaComprobacion_1_1:
                        Prefix = "BCE";
                        break;
                    case Tipo.PolizasPeriodo_1_1:
                        Prefix = "PLZ";
                        break;
                    case Tipo.AuxiliarCtas_1_1:
                        Prefix = "PLZ";
                        break;
                    case Tipo.AuxiliarFolios_1_2:
                        Prefix = "RepAux";
                        break;
                    case Tipo.CFDI_3_3:
                        Prefix = "cfdi";
                        break;
                    case Tipo.ComercioExterior_1_1:
                        Prefix = "cce11";
                        break;
                    default:
                        Prefix = "xsi";
                        break;
                }
            return Prefix;
        }

        private static string GetNameSpace(Tipo t)
        {
            string NameSpace;
            switch (t)
            {
                case Tipo.CatalogoCuentas_1_1:
                    NameSpace = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/CatalogoCuentas";
                    break;
                case Tipo.BalanzaComprobacion_1_1:
                    NameSpace = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/BalanzaComprobacion";
                    break;
                case Tipo.PolizasPeriodo_1_1:
                    NameSpace = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/PolizasPeriodo";
                    break;
                case Tipo.AuxiliarCtas_1_1:
                    NameSpace = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/AuxiliarCtas";
                    break;
                case Tipo.AuxiliarFolios_1_2:
                    NameSpace =  "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/AuxiliarFolios";
                    break;
                case Tipo.CFDI_3_3:
                    NameSpace = "http://www.sat.gob.mx/cfd/3";
                    break;
                case Tipo.ComercioExterior_1_1:
                    NameSpace = "http://www.sat.gob.mx/ComercioExterior11";
                    break;
                default:
                    NameSpace = "http://www.w3.org/2001/XMLSchema-instance";
                    break;
            }
            return NameSpace;
        }

        private static XmlSerializerNamespaces GetNameSpaces(Tipo t)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            switch (t)
            {
                case Tipo.CatalogoCuentas_1_1:
                    ns.Add("catalogocuentas", "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/CatalogoCuentas");
                    break;
                case Tipo.BalanzaComprobacion_1_1:
                    ns.Add("BCE", "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/BalanzaComprobacion");
                    break;
                case Tipo.PolizasPeriodo_1_1:
                    ns.Add("PLZ", "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/PolizasPeriodo");
                    break;
                case Tipo.AuxiliarCtas_1_1:
                    ns.Add("PLZ", "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/AuxiliarCtas");
                    break;
                case Tipo.AuxiliarFolios_1_2:
                    ns.Add("RepAux", "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/AuxiliarFolios");
                    break;
                case Tipo.CFDI_3_3:
                    ns.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
                    break;
                case Tipo.ComercioExterior_1_1:
                    ns.Add("cce11", "http://www.sat.gob.mx/ComercioExterior11");
                    break;
                default:
                    ns = null;
                    break;
            }
            return ns;
        }

        private static string GetTargetNameSpace(Tipo t)
        {
            string Target = null;
            switch (t)
            {
                case Tipo.CatalogoCuentas_1_1:
                    Target = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/CatalogoCuentas";
                    break;
                case Tipo.BalanzaComprobacion_1_1:
                    Target = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/BalanzaComprobacion";
                    break;
                case Tipo.PolizasPeriodo_1_1:
                    Target = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/PolizasPeriodo";
                    break;
                case Tipo.AuxiliarCtas_1_1:
                    Target = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/AuxiliarCtas";
                    break;
                case Tipo.AuxiliarFolios_1_2:
                    Target = "http://www.sat.gob.mx/esquemas/ContabilidadE/1_1/AuxiliarFolios";
                    break;
                case Tipo.CFDI_3_3:
                    Target = "http://www.sat.gob.mx/cfd/3";
                    break;
                default:
                    Target = null;
                    break;
            }
            return Target;
        }

        private static string GetSchemaUri(Tipo t)
        {
            string XsdPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string SchemaUri = null;
            switch (t)
            {
                case Tipo.CatalogoCuentas_1_1:
                    SchemaUri = "CatalogoCuentas_1_1.xsd";
                    break;
                case Tipo.BalanzaComprobacion_1_1:
                    SchemaUri = "BalanzaComprobacion_1_1.xsd";
                    break;
                case Tipo.PolizasPeriodo_1_1:
                    SchemaUri = "PolizasPeriodo_1_1.xsd";
                    break;
                case Tipo.AuxiliarCtas_1_1:
                    SchemaUri = "AuxiliarCtas_1_1.xsd";
                    break;
                case Tipo.AuxiliarFolios_1_2:
                    SchemaUri = "AuxiliarFolios_1_2.xsd";
                    break;
                case Tipo.CFDI_3_3:
                    SchemaUri = "cfdv33.xsd";
                    break;
                default:
                    SchemaUri = null;
                    break;
            }
            //return Path.Combine(XsdPath,SchemaUri)
                return SchemaUri;
        }
        public static string serializarXml(object c,Tipo TipoDocumento)
        {
            Type[] knownTypes = new Type[] { typeof(Comprobante), typeof(ComercioExterior) };

            XmlSerializer xs = new XmlSerializer(c.GetType());//, knownTypes);
            Stream stream = new MemoryStream();
            XmlTextWriter xtWriter = new XmlTextWriter(stream, Encoding.UTF8);
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add(GetPrefix(Tipo.Default), GetNameSpace(Tipo.Default));
            ns.Add(GetPrefix(TipoDocumento), GetNameSpace(TipoDocumento));
            if(TipoDocumento == Tipo.CFDI_3_3)
            {
                Comprobante comp = (Comprobante)c;
                if(comp.Complemento != null && comp.Complemento.ComercioExterior != null) ns.Add(GetPrefix(Tipo.ComercioExterior_1_1), GetNameSpace(Tipo.ComercioExterior_1_1));
            }
            xs.Serialize(xtWriter, c, ns);
            xtWriter.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            return reader.ReadToEnd();

            //XmlSerializer xs = new XmlSerializer(c.GetType());
            //XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            //ns = GetNameSpaces(TipoDocumento);
            //StringWriter sw = new StringWriter();
            //xs.Serialize(sw, c, ns);
            //string serializado = sw.ToString();
            //sw.Close();
            //return serializado;
        }

        public static string GenerarCFDISinTimbre(object c, Tipo TipoDocumento)
        {
            XmlSerializer xs = new XmlSerializer(c.GetType());//, knownTypes);
            Stream stream = new MemoryStream();
            XmlTextWriter xtWriter = new XmlTextWriter(stream, Encoding.UTF8);
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add(GetPrefix(Tipo.Default), GetNameSpace(Tipo.Default));
            ns.Add(GetPrefix(TipoDocumento), GetNameSpace(TipoDocumento));
            if (TipoDocumento == Tipo.CFDI_3_3)
            {
                Comprobante comp = (Comprobante)c;
                if (comp.Complemento != null && comp.Complemento.ComercioExterior != null) ns.Add(GetPrefix(Tipo.ComercioExterior_1_1), GetNameSpace(Tipo.ComercioExterior_1_1));
            }
            xs.Serialize(xtWriter, c, ns);
            xtWriter.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            return reader.ReadToEnd();
        }

        public static string GenerarCFDISellado(object c, Tipo TipoDocumento,string PathCertificado,string PathKey,string PassKey)
        {
            Comprobante comp = (Comprobante)c;
            if (TipoDocumento == Tipo.CFDI_3_3)
            {
                comp.NoCertificado = GetNumberCertificate(PathCertificado);
                comp.Certificado = GetStringCertificate(PathCertificado);
            }

            string xml = GenerarCFDISinTimbre(comp, TipoDocumento);

            string archivoXslt = @"cadenaoriginal_3_3.xslt";
            string CadenaOriginal = Common.GetOriginalChain(xml, archivoXslt);
            comp.Sello = Common.SignOriginalChain(PathKey, PassKey, CadenaOriginal);
            xml = GenerarCFDISinTimbre(comp, TipoDocumento);
            return xml;
        }

        public static string GenerarCFDITimbrado(object c, Tipo TipoDocumento, string PathCertificado, string PathKey, string PassKey,Pac Pac)
        {
            string xml = GenerarCFDISellado(c, TipoDocumento, PathCertificado, PathKey, PassKey);

            XmlDocument xmldoc2 = new XmlDocument();
            xmldoc2.LoadXml(xml);
            xmldoc2.Save("ejemplo.xml");
            string xmlCfdi;
            xmlCfdi = Common.ValidaXml(xml, SAT.Tipo.CFDI_3_3);
            Common.Timbrar(SAT.Pac.SolucionFactible, false, "ejemplo.xml", "testing@solucionfactible.com", "timbrado.SF.16672");

            return xml;
        }


        public static string ValidaXml(string xml, Tipo TipoDocumento)
        {
            string ms = "";
            try
            {
                
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xml);
                MemoryStream xmlStream = new MemoryStream();
                xmlDoc.Save(xmlStream);
                xmlStream.Flush();
                xmlStream.Position = 0;

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(GetTargetNameSpace(TipoDocumento), GetSchemaUri(TipoDocumento));
                settings.ValidationType = ValidationType.Schema;

                XmlReader reader = XmlReader.Create(xmlStream, settings);
                XmlDocument document = new XmlDocument();
                document.Load(reader);
                ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
                document.Validate(eventHandler);
            }
            catch (XmlSchemaException schemaEx)
            {
                ms = schemaEx.Message;
            }
            catch (Exception ex)
            {
                ms = ex.Message;
            }
            return ms;
            //catch (XmlSchemaException schemaEx)
            //{

            //    SaveError(10, schemaEx, schemaEx.Message + " [RECEPTOR: " + NOMBRE_RECEPTOR + "]");
            //    //tr.Close();
            //    System.IO.File.Delete(xmlFile);
            //    return false;
            //}

            //catch (Exception ex)
            //{

            //    SaveError(10, ex, ex.ToString());
            //    //tr.Close();
            //    System.IO.File.Delete(xmlFile);
            //    return false;
            //}
        }
        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                                   break;
                case XmlSeverityType.Warning:
                                break;
            }

        }

        public static string GetOriginalChain(string xml, string archivoXslt)
        {

            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(xml);
            XslCompiledTransform xlc = new XslCompiledTransform();
            xlc.Load(archivoXslt);
            StringWriter str = new StringWriter();
            XmlTextWriter myWriter = new XmlTextWriter(str);
            xlc.Transform(xDoc, null, myWriter);

            return str.ToString();
        }

        public static string GetNumberCertificate(string FileNameCert) 
        {
            X509Certificate2 cer = new X509Certificate2();
            byte[] rawData = ReadCertificado(FileNameCert);
            cer.Import(rawData);
            return Encoding.UTF8.GetString(cer.GetSerialNumber());
        }

        /// <summary>
        /// Devuelve cadena base 64 el certificado
        /// </summary>
        /// <param name="FileNameCert">Especificar la ruta del certificado digital</param>
        /// <returns></returns>
        public static string GetStringCertificate(string FileNameCert)
        {
            X509Certificate2 cer = new X509Certificate2();

            //bytes read file
            byte[] rawData = ReadCertificado(FileNameCert);

            cer.Import(rawData);
            return Convert.ToBase64String(cer.GetRawCertData());
        }

        private static byte[] ReadCertificado(string FileNameCert)
        {
            //bytes read file
            FileStream f = new FileStream(FileNameCert, FileMode.Open, FileAccess.Read);
            int size = (int)f.Length;
            byte[] data = new byte[size];
            size = f.Read(data, 0, size);
            f.Close();
            return data;
        }

        /// <summary>
        /// Get original chain and signing
        /// </summary>
        /// <param name="keyFileName">Name File Key</param>
        /// <param name="password">Pass from File Name Key</param>
        /// <param name="originalChain">Original chain</param>
        /// <returns></returns>
        public static string SignOriginalChain(string keyFileName, string password, string originalChain)
        {
            if (!System.IO.File.Exists(keyFileName))
            {
                return "Archivo .key no existe";
            }

            string SignedString = "";

            RSACryptoServiceProvider rsa = OpenKeyFile(keyFileName, password);
            if (rsa != null)
            {
                byte[] CO = Encoding.UTF8.GetBytes(originalChain);
                byte[] SignedBytes = rsa.SignData(CO, new SHA1CryptoServiceProvider());
                SignedString = Convert.ToBase64String(SignedBytes);
            }
            return SignedString;
        }

        //Read private key
        private static RSACryptoServiceProvider OpenKeyFile(String keyFileName, string password)
        {
            RSACryptoServiceProvider rsa = null;
            byte[] keyBytes = GetBytes(keyFileName);

            if (keyBytes == null)
                return null;

            rsa = DecodePrivateKey(keyBytes, password);	//PKCS #8 encrypted
            if (rsa != null)
            {
                return rsa;
            }

            return null;
        }


        private static RSACryptoServiceProvider DecodePrivateKey(byte[] keyBytes, string password)
        {
            // encoded OID sequence for  PKCS #1 rsaEncryption szOID_RSA_RSA = "1.2.840.113549.1.1.1"
            // this byte[] includes the sequence byte and terminal encoded null 
            byte[] OIDpkcs5PBES2 = { 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x0D };
            byte[] OIDpkcs5PBKDF2 = { 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x0C };
            byte[] OIDdesEDE3CBC = { 0x06, 0x08, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x03, 0x07 };
            byte[] seqdes = new byte[10];
            byte[] seq = new byte[11];
            byte[] salt;
            byte[] IV;
            byte[] encryptedpkcs8;
            byte[] pkcs8;

            int saltsize, ivsize, encblobsize;
            int iterations;

            // ---------  Set up stream to read the asn.1 encoded SubjectPublicKeyInfo blob  ------
            MemoryStream mem = new MemoryStream(keyBytes);
            BinaryReader binReader = new BinaryReader(mem);    //wrap Memory Stream with BinaryReader for easy reading
            byte bt = 0;
            ushort twobytes = 0;

            try
            {
                twobytes = binReader.ReadUInt16();
                if (twobytes == 0x8130)
                    //data read as little endian order (actual data order for Sequence is 30 81)
                    binReader.ReadByte();	//advance 1 byte
                else if (twobytes == 0x8230)
                    binReader.ReadInt16();	//advance 2 bytes
                else
                    return null;

                twobytes = binReader.ReadUInt16();	//inner sequence
                if (twobytes == 0x8130)
                    binReader.ReadByte();
                else if (twobytes == 0x8230)
                    binReader.ReadInt16();


                seq = binReader.ReadBytes(11);		//read the Sequence OID
                if (!Binary.CompareBytearrays(seq, OIDpkcs5PBES2))	//is it a OIDpkcs5PBES2 ?
                    return null;

                twobytes = binReader.ReadUInt16();	//inner sequence for pswd salt
                if (twobytes == 0x8130)
                    binReader.ReadByte();
                else if (twobytes == 0x8230)
                    binReader.ReadInt16();

                twobytes = binReader.ReadUInt16();	//inner sequence for pswd salt
                if (twobytes == 0x8130)
                    binReader.ReadByte();
                else if (twobytes == 0x8230)
                    binReader.ReadInt16();

                seq = binReader.ReadBytes(11);		//read the Sequence OID
                if (!Binary.CompareBytearrays(seq, OIDpkcs5PBKDF2))	//is it a OIDpkcs5PBKDF2 ?
                    return null;

                twobytes = binReader.ReadUInt16();
                if (twobytes == 0x8130)
                    binReader.ReadByte();
                else if (twobytes == 0x8230)
                    binReader.ReadInt16();

                bt = binReader.ReadByte();
                if (bt != 0x04)		//expect octet string for salt
                    return null;
                saltsize = binReader.ReadByte();
                salt = binReader.ReadBytes(saltsize);

                bt = binReader.ReadByte();
                if (bt != 0x02) 	//expect an integer for PBKF2 interation count
                    return null;

                int itbytes = binReader.ReadByte();	//PBKD2 iterations should fit in 2 bytes.
                if (itbytes == 1)
                    iterations = binReader.ReadByte();
                else if (itbytes == 2)
                    iterations = 256 * binReader.ReadByte() + binReader.ReadByte();
                else
                    return null;

                twobytes = binReader.ReadUInt16();
                if (twobytes == 0x8130)
                    binReader.ReadByte();
                else if (twobytes == 0x8230)
                    binReader.ReadInt16();


                seqdes = binReader.ReadBytes(10);		//read the Sequence OID
                if (!Binary.CompareBytearrays(seqdes, OIDdesEDE3CBC))	//is it a OIDdes-EDE3-CBC ?
                    return null;

                bt = binReader.ReadByte();
                if (bt != 0x04)		//expect octet string for IV
                    return null;
                ivsize = binReader.ReadByte();	// IV byte size should fit in one byte (24 expected for 3DES)
                IV = binReader.ReadBytes(ivsize);

                bt = binReader.ReadByte();
                if (bt != 0x04)		// expect octet string for encrypted PKCS8 data
                    return null;


                bt = binReader.ReadByte();

                if (bt == 0x81)
                    encblobsize = binReader.ReadByte();	// data size in next byte
                else if (bt == 0x82)
                    encblobsize = 256 * binReader.ReadByte() + binReader.ReadByte();
                else
                    encblobsize = bt;		// we already have the data size


                encryptedpkcs8 = binReader.ReadBytes(encblobsize);
                SecureString secpswd = new SecureString();
                foreach (char c in password)
                    secpswd.AppendChar(c);

                pkcs8 = DecryptPBDK2(encryptedpkcs8, salt, IV, secpswd, iterations);
                if (pkcs8 == null)	// probably a bad pswd entered.
                    return null;

                RSACryptoServiceProvider rsa = DecodePrivateKeyInfo(pkcs8);
                return rsa;
            }

            catch (Exception)
            {
                return null;
            }
            finally { binReader.Close(); }
        }

        private static RSACryptoServiceProvider DecodePrivateKeyInfo(byte[] pkcs8)
        {
            // encoded OID sequence for  PKCS #1 rsaEncryption szOID_RSA_RSA = "1.2.840.113549.1.1.1"
            // this byte[] includes the sequence byte and terminal encoded null 
            byte[] SeqOID = { 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, 0x05, 0x00 };
            byte[] seq = new byte[15];
            // ---------  Set up stream to read the asn.1 encoded SubjectPublicKeyInfo blob  ------
            MemoryStream mem = new MemoryStream(pkcs8);
            int lenstream = (int)mem.Length;
            BinaryReader binr = new BinaryReader(mem);    //wrap Memory Stream with BinaryReader for easy reading
            byte bt = 0;
            ushort twobytes = 0;

            try
            {

                twobytes = binr.ReadUInt16();
                if (twobytes == 0x8130)	//data read as little endian order (actual data order for Sequence is 30 81)
                    binr.ReadByte();	//advance 1 byte
                else if (twobytes == 0x8230)
                    binr.ReadInt16();	//advance 2 bytes
                else
                    return null;


                bt = binr.ReadByte();
                if (bt != 0x02)
                    return null;

                twobytes = binr.ReadUInt16();

                if (twobytes != 0x0001)
                    return null;

                seq = binr.ReadBytes(15);		//read the Sequence OID
                if (!Binary.CompareBytearrays(seq, SeqOID))	//make sure Sequence for OID is correct
                    return null;

                bt = binr.ReadByte();
                if (bt != 0x04)	//expect an Octet string 
                    return null;

                bt = binr.ReadByte();		//read next byte, or next 2 bytes is  0x81 or 0x82; otherwise bt is the byte count
                if (bt == 0x81)
                    binr.ReadByte();
                else
                    if (bt == 0x82)
                    binr.ReadUInt16();
                //------ at this stage, the remaining sequence should be the RSA private key

                byte[] rsaprivkey = binr.ReadBytes((int)(lenstream - mem.Position));
                RSACryptoServiceProvider rsacsp = DecodeRSAPrivateKey(rsaprivkey);
                return rsacsp;
            }

            catch (Exception)
            {
                return null;
            }

            finally { binr.Close(); }
        }

        private static byte[] DecryptPBDK2(byte[] edata, byte[] salt,
              byte[] IV, SecureString secpswd, int iterations)
        {
            CryptoStream decrypt = null;

            IntPtr unmanagedPswd = IntPtr.Zero;
            byte[] psbytes = new byte[secpswd.Length];
            unmanagedPswd = Marshal.SecureStringToGlobalAllocAnsi(secpswd);
            Marshal.Copy(unmanagedPswd, psbytes, 0, psbytes.Length);
            Marshal.ZeroFreeGlobalAllocAnsi(unmanagedPswd);

            try
            {
                Rfc2898DeriveBytes kd = new Rfc2898DeriveBytes(psbytes, salt, iterations);
                TripleDES decAlg = TripleDES.Create();
                decAlg.Key = kd.GetBytes(24);
                decAlg.IV = IV;
                MemoryStream memstr = new MemoryStream();
                decrypt = new CryptoStream(memstr, decAlg.CreateDecryptor(), CryptoStreamMode.Write);
                decrypt.Write(edata, 0, edata.Length);
                decrypt.Flush();
                decrypt.Close();	// this is REQUIRED.
                byte[] cleartext = memstr.ToArray();
                return cleartext;
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem decrypting: {0}", e.Message);
                return null;
            }
        }

        private static RSACryptoServiceProvider DecodeRSAPrivateKey(byte[] privkey)
        {
            byte[] MODULUS, E, D, P, Q, DP, DQ, IQ;

            // ---------  Set up stream to decode the asn.1 encoded RSA private key  ------
            MemoryStream mem = new MemoryStream(privkey);
            BinaryReader binr = new BinaryReader(mem);    //wrap Memory Stream with BinaryReader for easy reading
            byte bt = 0;
            ushort twobytes = 0;
            int elems = 0;
            try
            {
                twobytes = binr.ReadUInt16();
                if (twobytes == 0x8130)	//data read as little endian order (actual data order for Sequence is 30 81)
                    binr.ReadByte();	//advance 1 byte
                else if (twobytes == 0x8230)
                    binr.ReadInt16();	//advance 2 bytes
                else
                    return null;

                twobytes = binr.ReadUInt16();
                if (twobytes != 0x0102)	//version number
                    return null;
                bt = binr.ReadByte();
                if (bt != 0x00)
                    return null;


                //------  all private key components are Integer sequences ----
                elems = Binary.GetIntegerSize(binr);
                MODULUS = binr.ReadBytes(elems);

                elems = Binary.GetIntegerSize(binr);
                E = binr.ReadBytes(elems);

                elems = Binary.GetIntegerSize(binr);
                D = binr.ReadBytes(elems);

                elems = Binary.GetIntegerSize(binr);
                P = binr.ReadBytes(elems);

                elems = Binary.GetIntegerSize(binr);
                Q = binr.ReadBytes(elems);

                elems = Binary.GetIntegerSize(binr);
                DP = binr.ReadBytes(elems);

                elems = Binary.GetIntegerSize(binr);
                DQ = binr.ReadBytes(elems);

                elems = Binary.GetIntegerSize(binr);
                IQ = binr.ReadBytes(elems);

                Console.WriteLine("showing components ..");

                // ------- create RSACryptoServiceProvider instance and initialize with public key -----
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSAParameters RSAparams = new RSAParameters();
                RSAparams.Modulus = MODULUS;
                RSAparams.Exponent = E;
                RSAparams.D = D;
                RSAparams.P = P;
                RSAparams.Q = Q;
                RSAparams.DP = DP;
                RSAparams.DQ = DQ;
                RSAparams.InverseQ = IQ;
                RSA.ImportParameters(RSAparams);
                return RSA;
            }
            catch (Exception)
            {
                return null;
            }
            finally { binr.Close(); }
        }

        public static byte[] GetBytes(string fileName)
        {
            using (Stream stm = new FileStream(fileName, FileMode.Open))
            {
                byte[] fbytes = new byte[stm.Length];
                stm.Seek(0, SeekOrigin.Begin);
                stm.Read(fbytes, 0, (int)stm.Length);
                stm.Close();
                return fbytes;
            }
        }
    }
}
