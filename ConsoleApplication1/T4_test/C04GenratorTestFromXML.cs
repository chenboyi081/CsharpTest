  
  
  
  
  
  
using System;using System.Collections.Generic;using System.Linq;using System.Xml;namespace MyProject{  
  
    partial class Catalog  
    {      
		private XmlNode thisNode;      
		public Catalog(XmlNode node) { thisNode = node; }  
  
  
		public IEnumerable<Artist>Artist 
		{         
			get {           
				 foreach (XmlNode node in thisNode.SelectNodes("artist"))              
				 yield return new Artist(node);       
				 }
		}  
  
		public IEnumerable<Test>Test 
		{         
			get {           
				 foreach (XmlNode node in thisNode.SelectNodes("test"))              
				 yield return new Test(node);       
				 }
		}  
  
   }   
  
    partial class Artist  
    {      
		private XmlNode thisNode;      
		public Artist(XmlNode node) { thisNode = node; }  
  
  
		public IEnumerable<Song>Song 
		{         
			get {           
				 foreach (XmlNode node in thisNode.SelectNodes("song"))              
				 yield return new Song(node);       
				 }
		}  
  
		public string id { 
			get { return thisNode.Attributes["id"].Value; } 
		}  
  
		public string name { 
			get { return thisNode.Attributes["name"].Value; } 
		}  
  
   }   
  
    partial class Song  
    {      
		private XmlNode thisNode;      
		public Song(XmlNode node) { thisNode = node; }  
  
  
      public string Text{ 
	  get { return thisNode.InnerText; } 
	  }  
  
		public string id { 
			get { return thisNode.Attributes["id"].Value; } 
		}  
  
   }   
  
    partial class Test  
    {      
		private XmlNode thisNode;      
		public Test(XmlNode node) { thisNode = node; }  
  
  
		public IEnumerable<Subtest>Subtest 
		{         
			get {           
				 foreach (XmlNode node in thisNode.SelectNodes("subtest"))              
				 yield return new Subtest(node);       
				 }
		}  
  
   }   
  
    partial class Subtest  
    {      
		private XmlNode thisNode;      
		public Subtest(XmlNode node) { thisNode = node; }  
  
  
      public string Text{ 
	  get { return thisNode.InnerText; } 
	  }  
  
		public string id { 
			get { return thisNode.Attributes["id"].Value; } 
		}  
  
   }   
  
   partial class Catalog   {      
   public Catalog(string fileName){       
    XmlDocument doc = new XmlDocument();      
	doc.Load(fileName);     
	 thisNode = doc.SelectSingleNode("catalog");
	}  
}}  
