using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ferreteria.Modelo;

namespace Ferreteria.Controlador
{
    class ControladorCLIENTE
    {
        
        public void listarCLIENTE(ListView listView)
        {
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = from m in db.CLIENTE select m;

                    foreach (var r in resultado )
                    {
                        ListViewItem i = new ListViewItem(r.IDCliente.ToString());
                         i.SubItems.Add(r.Nombre.ToString());
                         i.SubItems.Add(r.Apellido.ToString());
                         i.SubItems.Add(r.Dni.ToString());
                         i.SubItems.Add(r.FechaNacimiento.ToString());
                         i.SubItems.Add(r.Telefono.ToString());
                         i.SubItems.Add(r.Saldo.ToString());

                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }


        public void eliminarCLIENTE(ListView listView, String Buscado)
        {
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = from m in db.CLIENTE where m.Apellido.Contains(Buscado) select m;

                    foreach (var r in resultado)
                    {
                        ListViewItem i = new ListViewItem(r.IDCliente.ToString());
                        i.SubItems.Add(r.Nombre.ToString());
                        i.SubItems.Add(r.Apellido.ToString());
                        i.SubItems.Add(r.Dni.ToString());
                        i.SubItems.Add(r.FechaNacimiento.ToString());
                        i.SubItems.Add(r.Telefono.ToString());
                        i.SubItems.Add(r.Saldo.ToString());

                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }

        public void buscarCLIENTE(ListView listView, String Buscado)
        {
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = from m in db.CLIENTE where m.Apellido.Contains(Buscado) select m;

                    foreach (var r in resultado)
                    {
                        ListViewItem i = new ListViewItem(r.IDCliente.ToString());
                        i.SubItems.Add(r.Nombre.ToString());
                        i.SubItems.Add(r.Apellido.ToString());
                        i.SubItems.Add(r.Dni.ToString());
                        i.SubItems.Add(r.FechaNacimiento.ToString());
                        i.SubItems.Add(r.Telefono.ToString());
                        i.SubItems.Add(r.Saldo.ToString());
                     //   i.SubItems.Add(r.);
                       
                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }
        //MODIFICAR CLIENTE
        public void modificarCliente(int idCliente, String nombre, String apellido, int dni, DateTime fechaNacimiento, String telefono, decimal saldo)
        {
            try
            {

                using (var db = new FERRETERIAEntities())
                {
                     db.CLIENTE.Find(idCliente).Nombre = nombre;
                     db.CLIENTE.Find(idCliente).Apellido = apellido;
                     db.CLIENTE.Find(idCliente).Dni = dni;
                     db.CLIENTE.Find(idCliente).FechaNacimiento = fechaNacimiento;
                     db.CLIENTE.Find(idCliente).Telefono = telefono;
                     db.CLIENTE.Find(idCliente).Saldo = saldo;
               
                    db.SaveChanges();

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }


     
        //NUEVO CLIENTE
        public void nuevoCliente( String nombre, String apellido, int dni, DateTime fechaNacimiento, String telefono, decimal saldo)
        {
            try
            {

                using (var db = new FERRETERIAEntities())
                {
                    CLIENTE m = new CLIENTE();
                    m.Nombre = nombre;
                    m.Apellido=apellido;
                    m.Dni=dni;
                    m.FechaNacimiento = fechaNacimiento;// Convert.ToDateTime(fechaNacimiento);
                    m.Telefono = telefono;
                    m.Saldo=saldo;
                   
       
                    db.CLIENTE.Add(m);
                    
                    db.SaveChanges();

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }

    }

    }

