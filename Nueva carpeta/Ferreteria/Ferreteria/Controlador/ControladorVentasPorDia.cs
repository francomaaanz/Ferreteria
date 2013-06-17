using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ferreteria.Modelo;

namespace Ferreteria.Controlador
{
    class ControladorVentasPorDia
    {

        //LISTAR VENTA POR DIA
        public void listarVentaPorDia(ListView listView)
        {
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = from m in db.Ventas_Por_Dia select m;

                    foreach (var r in resultado)
                    {
                        ListViewItem i = new ListViewItem(r.IDVentasPorDia.ToString());
                        i.SubItems.Add(r.monto.ToString());
                        i.SubItems.Add(r.Fecha.ToString());

                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }

        // BUSCAR VENTA POR DIA
        //public void buscarVentaPorDia(ListView listView, DateTime Buscado)
        //{
        //    try
        //    {
        //        listView.Items.Clear();
        //        using (var db = new FERRETERIAEntities())
        //        {
        //            var resultado = from m in db.Ventas_Por_Dia where m.Fecha.Contains(Buscado) select m;

        //            foreach (var r in resultado)
        //            {
        //                ListViewItem i = new ListViewItem(r.IDVentasPorDia.ToString());
        //                i.SubItems.Add(r.monto.ToString());
        //                i.SubItems.Add(r.Fecha.ToString());

        //                listView.Items.Add(i);
        //            }
        //        }
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        //    finally { }
        //}

        //MODIFICAR VENTA POR DIA
        public void modificarVentaPorDia(DateTime fecha, decimal monto,  int IDventaPorDia)
        {
            try
            {
                using (var db = new FERRETERIAEntities())
                {
                    db.Ventas_Por_Dia.Find(IDventaPorDia).monto = monto;
                    db.Ventas_Por_Dia.Find(IDventaPorDia).Fecha = fecha;
                   
                    db.SaveChanges();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }



        //NUEVO VENTA POR DIA

        public void nuevoVentaPorDia(DateTime fecha, decimal monto)
        {
            try
            {
                using (var db = new FERRETERIAEntities())
                {
                    Ventas_Por_Dia p = new Ventas_Por_Dia();
                    p.monto = monto;
                    p.Fecha = fecha; 

                    db.Ventas_Por_Dia.Add(p);
                    db.SaveChanges();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }
    }
}
