using Models.Interfaces;

namespace Models.Common
{
    /// <summary>
    ///     Modelado de la tabla Producto
    /// </summary>
    public class Producto : IIdentity, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <summary>
        ///     Precio estimado del producto
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        ///     Descripción del producto
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        ///     
        /// </summary>
        public int Stock { get; set; } // recien agregado

        #region Foreing Key

        /// <summary>
        ///     Id de la categoria asociada
        /// </summary>
        public int IdCategoria { get; set; }

        /// <summary>
        ///     Id de la categoria asociada
        /// </summary>
        public int IdHistoricoProducto { get; set; } // Recien agregado

       /// <summary>
       ///      Id de la Garantia asociada 
       /// </summary>
        public int IdGarantia { get; set; } // recien agregado

        #endregion
    }
}