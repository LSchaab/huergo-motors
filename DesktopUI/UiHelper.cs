using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using Negocio;

namespace DesktopUI
{
    public class UiHelper
    {
        private readonly VehiculosNegocio vehiculosNegocio = new VehiculosNegocio();

        private readonly VendedoresNegocio vendedoresNegocio = new VendedoresNegocio();

        private readonly AccesoriosNegocio accesoriosNegocio = new AccesoriosNegocio();


        /// <summary>
        /// Devuelve true si el formulario pasado esta abierto, false sino
        /// </summary>
        /// <param name="formulario"></param>
        /// <returns>bool (true / false)</returns>
        public static bool EstaAbierto(Form formulario)
        {
            FormCollection formulariosAbiertos = Application.OpenForms;
            foreach (Form formularioAbierto in formulariosAbiertos)
            {
                if (formularioAbierto.GetType() == formulario.GetType())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Llena el dataSource, displayMember y valueMember de un combo con todos los modelos de vehiculos
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="displayMember"></param>
        /// <param name="valueMember"></param>
        public void LlenarComboModeloVehiculos(ComboBox combo, string displayMember, string valueMember)
        {
            try
            {
                List<Vehiculos> vehiculos = vehiculosNegocio.LeerTodosModelos();
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                combo.DataSource = vehiculos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Llena el dataSource, displayMember y valueMember de un combo con todos los nombres de los vendedores
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="displayMember"></param>
        /// <param name="valueMember"></param>
        public void LlenarComboVendedores(ComboBox combo, string displayMember, string valueMember)
        {
            try
            {
                List<Vendedores> vendedores = vendedoresNegocio.LeerTodosNombresCompletos();
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                combo.DataSource = vendedores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Llena el dataSource, displayMember y valueMember de un combo con todos los accesorios de un id de vehiculo dado
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="idVehiculo"></param>
        /// <param name="displayMember"></param>
        /// <param name="valueMember"></param>
        public void LlenarComboAccesorios(ComboBox combo, int idVehiculo, string displayMember, string valueMember)
        {
            List<Accesorios> accesorios = accesoriosNegocio.LeerPorIdVehiculo(idVehiculo);
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.DataSource = accesorios;
        }
    }
}
