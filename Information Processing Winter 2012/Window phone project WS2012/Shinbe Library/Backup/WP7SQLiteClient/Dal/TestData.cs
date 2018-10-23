using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;//INotifyPropertyChanged
namespace WP7SQLiteClient.Dal
{
 
    /// <summary>
    /// Gets the TestDataEntries property.
    /// Changes to that property's value raise the PropertyChanged event.
    /// <summary>

    //public class TestData : INotifyPropertyChanged
    public class Library
    {
        public int ID { get; set; }
        public string Book { get; set; }
        public string Gerne { get; set; }
        public string Author { get; set; }
        public string Editor { get; set; }
     
        public string Yearofpublication { get; set; }
        public string Edition { get; set; }
        public string ISBN { get; set; }
       
        public string Purchasedate { get; set; }
        public string Purchaseprice { get; set; }
        public string Currentvalue { get; set; }
        public string Loanedoutto { get; set; }
        public string Conditionloanout { get; set; }
        
        public string Loanoutdate { get; set; }
        public string Additionalinfo { get; set; }
        public string Imname { get; set; }
        public string Imaddress { get; set; }
        public string Imhomepage { get; set; }
        public string Imemail { get; set; }
        public string Reauthor { get; set; }
        public string Retext { get; set; }
        public string Readdinfo { get; set; }
        public string Ausurname { get; set; }
        public string Auforename { get; set; }
        public string Auhomepage { get; set; }
        public string Auemail { get; set; }
        public string Aucv { get; set; }
        public string Edsurname { get; set; }
        public string Edforename { get; set; }
        public string Edhomepage { get; set; }
        public string Edemail { get; set; }
        public string Puname { get; set; }
        public string Pulocation { get; set; }
        public string Pucountry { get; set; }
        public string Puhomepage { get; set; }
        public string Puemail { get; set; }
        public string Boname { get; set; }
        public string Boaddress { get; set; }
        public string Boemail { get; set; }
        public string Bohomepage { get; set; }
        public string Bophone { get; set; }
        public string Bonewemail { get; set; }
        public string Bonewordmail { get; set; }
        public string Boassbooks { get; set; }
        public string Boevents { get; set; }
        public string Bospeciality { get; set; }
        public string Bbaddress { get; set; }
        public string Bbphone { get; set; }
        public string Bbhomepage { get; set; }
        public string Bbemail { get; set; }
        public string Racapacity { get; set; }
        public string Rahumidcontrol { get; set; }
        public string Rahumidity { get; set; }
        public string Rahumidrevalue { get; set; }
        public string Ratemcontrol { get; set; }
        public string Ratemperature { get; set; }
        public string Ratemrefval { get; set; }
        public string Raaddinfo { get; set; }
        public string Sllocname { get; set; }
        public string Sladdress { get; set; }
        public string Slroom { get; set; }
        public string Slracklabel { get; set; }
        public string Slshelflabel { get; set; }
        public string Slhumidity { get; set; }
        public string Slhumidrefvalue { get; set; }
        public string Slhumidcontrol { get; set; }
        public string Sltemperature { get; set; }
        public string Sltemrefvalue { get; set; }
        public string Sltemcontrol { get; set; }
        public string Slattribute { get; set; }

        public Library() { }
        public Library(int Id,
                         string book,
                         string gerne,
                         string author,
                         string editor,
                         
                         string yearofpublication,
                         string edition,
                         string isbn,
                         string review,

                         string purchasedate,
                         string purchaseprice,
                         string currentvalue,
                         string loanedoutto,
                         string conditionloanout,
                      
                         string loanoutdate,
                         string additionalinfo,

                         string imname,
                         string imaddress,
                         string imhomepage,
                         string imemail,

                         string reauthor,
                         string retext,
                         string readdinfo,

                         string ausurname,
                         string auforename,
                         string auhomepage,
                         string auemail,
                         string aucv,

                         string edsurname,
                         string edforename,
                         string edhomepage,
                         string edemail,

                         string puname,
                         string pulocation,
                         string pucountry,
                         string puhomepage,
                         string puemail,

                         string boname,
                         string boaddress,
                         string boemail,
                         string bohomepage,
                         string bophone,
                         string bonewemail,
                         string bonewordmail,
                         string boassbooks,
                         string boevents,
                         string bospeciality,

                         string bbaddress,
                         string bbphone,
                         string bbhomepage,
                         string bbemail,

                         string racapacity,
                         string rahumidcontrol,
                         string rahumidity,
                         string rahumidrevalue,
                         string ratemcontrol,
                         string ratemperature,
                         string ratemrefval,
                         string raaddinfo,

                         string sllocname,
                         string sladdress,
                         string slroom,
                         string slracklabel,
                         string slshelflabel,
                         string slhumidity,
                         string slhumidrefvalue,
                         string slhumidcontrol,
                         string sltemperature,
                         string sltemrefvalue,
                         string sltemcontrol,
                         string slattribute)
        {
            ID =  Id;
            Book = book;
            Gerne = gerne;
            Author = author;
            Editor = editor;
         
            Yearofpublication = yearofpublication;
            Edition = edition;
            ISBN = isbn;
          

            Purchasedate = purchasedate;
            Purchaseprice = purchaseprice;
            Currentvalue = currentvalue;
            Loanedoutto = loanedoutto;
            Conditionloanout = conditionloanout;
           
            Loanoutdate = loanoutdate;
            Additionalinfo = additionalinfo;

            Imname = imname;
            Imaddress = imaddress;
            Imhomepage = imhomepage;
            Imemail = imemail;

            Reauthor = reauthor;
            Retext = retext;
            Readdinfo = readdinfo;

            Ausurname = ausurname;
            Auforename = auforename;
            Auhomepage = auhomepage;
            Auemail = auemail;
            Aucv = aucv;

            Edsurname = edsurname;
            Edforename = edforename;
            Edhomepage = edhomepage;
            Edemail = edemail;

            Puname = puname;
            Pulocation = pulocation;
            Pucountry = pucountry;
            Puhomepage = puhomepage;
            Puemail = puemail;

            Boname = boname;
            Boaddress = boaddress;
            Boemail = boemail;
            Bohomepage = bohomepage;
            Bophone = bophone;
            Bonewemail = bonewemail;
            Bonewordmail = bonewordmail;
            Boassbooks = boassbooks;
            Boevents = boevents;
            Bospeciality = bospeciality;

            Bbaddress = bbaddress;
            Bbphone = bbphone;
            Bbhomepage = bbhomepage;
            Bbemail = bbemail;

            Racapacity = racapacity;
            Rahumidcontrol = rahumidcontrol;
            Rahumidity = rahumidity;
            Rahumidrevalue = rahumidrevalue;
            Ratemcontrol = ratemcontrol;
            Ratemperature = ratemperature;
            Ratemrefval = ratemrefval;
            Raaddinfo = raaddinfo;

            Sllocname = sllocname;
            Sladdress = sladdress;
            Slroom = slroom;
            Slracklabel = slracklabel;
            Slshelflabel = slshelflabel;
            Slhumidity = slhumidity;
            Slhumidrefvalue = slhumidrefvalue;
            Slhumidcontrol = slhumidcontrol;
            Sltemperature = sltemperature;
            Sltemrefvalue = sltemrefvalue;
            Sltemcontrol = sltemcontrol;
            Slattribute = slattribute;
        }
        
    }
   
}
