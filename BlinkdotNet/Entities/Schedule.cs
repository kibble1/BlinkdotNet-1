//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;


namespace BlinkdotNet.Entities
{
    
    
    [DataContract()]
    public class Schedule
    {
        
        [DataMember(Name="action")]
        private string action;
        
        [DataMember(Name="devices")]
        private System.Collections.Generic.List<string> devices;
        
        [DataMember(Name="dow")]
        private System.Collections.Generic.List<string> dow;
        
        [DataMember(Name="id")]
        private int id;
        
        [DataMember(Name="time")]
        private string time;
        
        public string Action
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
            }
        }
        
        public System.Collections.Generic.List<string> Devices
        {
            get
            {
                return devices;
            }
            set
            {
                devices = value;
            }
        }
        
        public System.Collections.Generic.List<string> Dow
        {
            get
            {
                return dow;
            }
            set
            {
                dow = value;
            }
        }
        
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        
        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
    }
}
