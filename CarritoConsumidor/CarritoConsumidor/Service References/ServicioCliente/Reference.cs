﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarritoConsumidor.ServicioCliente {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://co.edu.eam.ingsoft.distribuidos", ConfigurationName="ServicioCliente.ClientesController")]
    public interface ClientesController {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="crearElCliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        CarritoConsumidor.ServicioCliente.operacionCrearResponse operacionCrear(CarritoConsumidor.ServicioCliente.operacionCrear request);
        
        [System.ServiceModel.OperationContractAttribute(Action="crearElCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<CarritoConsumidor.ServicioCliente.operacionCrearResponse> operacionCrearAsync(CarritoConsumidor.ServicioCliente.operacionCrear request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://co.edu.eam.ingsoft.distribuidos")]
    public partial class cliente : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string apellidoField;
        
        private string cedulaField;
        
        private string correoField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string nombreField;
        
        private string telefonoField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("apellido");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string cedula {
            get {
                return this.cedulaField;
            }
            set {
                this.cedulaField = value;
                this.RaisePropertyChanged("cedula");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("idSpecified");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("telefono");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="operacionCrear", WrapperNamespace="http://co.edu.eam.ingsoft.distribuidos", IsWrapped=true)]
    public partial class operacionCrear {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://co.edu.eam.ingsoft.distribuidos", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CarritoConsumidor.ServicioCliente.cliente client;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://co.edu.eam.ingsoft.distribuidos", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string contrasenia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://co.edu.eam.ingsoft.distribuidos", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        public operacionCrear() {
        }
        
        public operacionCrear(CarritoConsumidor.ServicioCliente.cliente client, string contrasenia, string usuario) {
            this.client = client;
            this.contrasenia = contrasenia;
            this.usuario = usuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="operacionCrearResponse", WrapperNamespace="http://co.edu.eam.ingsoft.distribuidos", IsWrapped=true)]
    public partial class operacionCrearResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://co.edu.eam.ingsoft.distribuidos", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public operacionCrearResponse() {
        }
        
        public operacionCrearResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClientesControllerChannel : CarritoConsumidor.ServicioCliente.ClientesController, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientesControllerClient : System.ServiceModel.ClientBase<CarritoConsumidor.ServicioCliente.ClientesController>, CarritoConsumidor.ServicioCliente.ClientesController {
        
        public ClientesControllerClient() {
        }
        
        public ClientesControllerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientesControllerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesControllerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesControllerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CarritoConsumidor.ServicioCliente.operacionCrearResponse CarritoConsumidor.ServicioCliente.ClientesController.operacionCrear(CarritoConsumidor.ServicioCliente.operacionCrear request) {
            return base.Channel.operacionCrear(request);
        }
        
        public string operacionCrear(CarritoConsumidor.ServicioCliente.cliente client, string contrasenia, string usuario) {
            CarritoConsumidor.ServicioCliente.operacionCrear inValue = new CarritoConsumidor.ServicioCliente.operacionCrear();
            inValue.client = client;
            inValue.contrasenia = contrasenia;
            inValue.usuario = usuario;
            CarritoConsumidor.ServicioCliente.operacionCrearResponse retVal = ((CarritoConsumidor.ServicioCliente.ClientesController)(this)).operacionCrear(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CarritoConsumidor.ServicioCliente.operacionCrearResponse> CarritoConsumidor.ServicioCliente.ClientesController.operacionCrearAsync(CarritoConsumidor.ServicioCliente.operacionCrear request) {
            return base.Channel.operacionCrearAsync(request);
        }
        
        public System.Threading.Tasks.Task<CarritoConsumidor.ServicioCliente.operacionCrearResponse> operacionCrearAsync(CarritoConsumidor.ServicioCliente.cliente client, string contrasenia, string usuario) {
            CarritoConsumidor.ServicioCliente.operacionCrear inValue = new CarritoConsumidor.ServicioCliente.operacionCrear();
            inValue.client = client;
            inValue.contrasenia = contrasenia;
            inValue.usuario = usuario;
            return ((CarritoConsumidor.ServicioCliente.ClientesController)(this)).operacionCrearAsync(inValue);
        }
    }
}
