//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ferreteria.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class PEDIDO_PROVEEDOR
    {
        public int ID_PEDIDO_PROVEEDOR { get; set; }
        public int IDproveedor { get; set; }
        public System.DateTime FechaPedido { get; set; }
        public System.DateTime FechaLLegada { get; set; }
        public string Estado { get; set; }
        public string TiempoDemoraPedido { get; set; }
    
        public virtual Estado_Pedido Estado_Pedido { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}
