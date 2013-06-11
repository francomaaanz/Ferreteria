using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ferreteria.Controlador;
using Ferreteria.Modelo;

namespace Ferreteria.Controlador
{
    class ControladorProveedor
    {

        //LISTAR PROVEEDOR
        public void listarProveedorE(ListView listView)
        {
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = from m in db.PROVEEDOR select m;

                    foreach (var r in resultado)
                    {
                        ListViewItem i = new ListViewItem(r.IDproveedor.ToString());
                        i.SubItems.Add(r.RazonSocial.ToString());
                        i.SubItems.Add(r.CUIT.ToString());
                        i.SubItems.Add(r.Direccion.ToString());
                        i.SubItems.Add(r.Telefono.ToString());
                        i.SubItems.Add(r.NumeroDeCuenta1.ToString()); 
                        i.SubItems.Add(r.NumeroDeCuenta2.ToString());
                        i.SubItems.Add(r.CBU.ToString());
                        i.SubItems.Add(r.CodigoPostal.ToString());
                        i.SubItems.Add(r.ProvinciaCiudad.ToString());
                   
                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }

        public void cargarCboProveedor(ComboBox cboProveedor) {


            try
            {
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = from m in db.PROVEEDOR select m;

                    foreach (var r in resultado)
                    {
                        
                        cboProveedor.Items.Add(r.RazonSocial);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        
        }

        public int obtenerIDProveedor(String razonSocial)
        {


            try
            {
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = (from m in db.PROVEEDOR where m.RazonSocial == razonSocial  select m).Single();

                    return resultado.IDproveedor;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());
            return 0;
            }
            finally { }

        }

        //BUSCAR PROVEEDOR
        public void buscarProveedor(ListView listView, String Buscado)
        {
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = from m in db.PROVEEDOR where m.RazonSocial.Contains(Buscado) select m;

                    foreach (var r in resultado)
                    {
                        ListViewItem i = new ListViewItem(r.IDproveedor.ToString());
                        i.SubItems.Add(r.RazonSocial.ToString());
                        i.SubItems.Add(r.CUIT.ToString());
                        i.SubItems.Add(r.Direccion.ToString());
                        i.SubItems.Add(r.Telefono.ToString());
                        i.SubItems.Add(r.NumeroDeCuenta1.ToString());
                        i.SubItems.Add(r.NumeroDeCuenta2.ToString());
                        i.SubItems.Add(r.CBU.ToString());
                        i.SubItems.Add(r.CodigoPostal.ToString());
                        i.SubItems.Add(r.ProvinciaCiudad.ToString());
                    

                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }

        //MODIFICAR CLIENTE
        public void modificarProveedor(String RazonSocial, String CUIT, String Direccion, String CodigoPostal, String telefono, String ProvinciaCiudad,
                                    String NumeroDeCuenta1, String NumeroDeCuenta2, String CBU, int IDproveedor)
        {
            try
            {

                using (var db = new FERRETERIAEntities())
                {
                    db.PROVEEDOR.Find(IDproveedor).RazonSocial = RazonSocial;
                    db.PROVEEDOR.Find(IDproveedor).CUIT = CUIT;
                    db.PROVEEDOR.Find(IDproveedor).Direccion = Direccion;
                    db.PROVEEDOR.Find(IDproveedor).CodigoPostal = CodigoPostal;
                    db.PROVEEDOR.Find(IDproveedor).Telefono = telefono;
                    db.PROVEEDOR.Find(IDproveedor).NumeroDeCuenta1 = NumeroDeCuenta1;
                    db.PROVEEDOR.Find(IDproveedor).NumeroDeCuenta2 = NumeroDeCuenta2;
                    db.PROVEEDOR.Find(IDproveedor).CBU = CBU;
                    db.PROVEEDOR.Find(IDproveedor).NumeroDeCuenta1 = NumeroDeCuenta1;
                    db.SaveChanges();

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }


        //NUEVO PROVEEDOR
        public void nuevoProveedor(String RazonSocial, String CUIT, String Direccion, String ProvinciaCiudad, 
            String telefono, String CodigoPostal, String NumeroDeCuenta1, String NumeroDeCuenta2,String CBU)
        {
            try
            {

                using (var db = new FERRETERIAEntities())
                {
                    PROVEEDOR p = new PROVEEDOR();
                    p.RazonSocial = RazonSocial;
                    p.CUIT = CUIT;
                    p.Direccion = Direccion;
                    p.ProvinciaCiudad = ProvinciaCiudad;
                    p.Telefono = telefono;
                    p.CodigoPostal = CodigoPostal;
                    p.NumeroDeCuenta1 = NumeroDeCuenta1;
                    p.NumeroDeCuenta2= NumeroDeCuenta2;
                    p.CBU=CBU;


                    db.PROVEEDOR.Add(p);
                    db.SaveChanges();

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }
    }
}
