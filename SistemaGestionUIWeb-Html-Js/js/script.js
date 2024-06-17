//import { productNavLink, soldProductNavLink, userNavLink, saleNavLink, contentArea } from './constantes.js';
const productNavLink = document.getElementById('product-nav');
const soldProductNavLink = document.getElementById('sold-product-nav');
const userNavLink = document.getElementById('user-nav');
const saleNavLink = document.getElementById('sale-nav');
const contentArea = document.getElementById('content-area');


function handleNavigation(event) {
    event.preventDefault();
    const target = event.target.id;
  
    switch (target) {
      case 'product-nav':
        showProductTable();
        break;
      case 'sold-product-nav':
        showSoldProductTable();
        break;
      case 'user-nav':
        showUserTable();
        break;
      case 'sale-nav':
        showSaleTable();
        break;
      default:
        break;
    }
  }
  
  productNavLink.addEventListener('click', handleNavigation);
  soldProductNavLink.addEventListener('click', handleNavigation);
  userNavLink.addEventListener('click', handleNavigation);
  saleNavLink.addEventListener('click', handleNavigation);

function showProductTable() {
  // Código para mostrar la tabla de Productos
  contentArea.innerHTML = ''; // Limpiar el área de contenido

  fetch('https://localhost:7214/api/producto')
    .then(response => response.json())
    .then(data => {
      const productTable = document.createElement('table');
      const tableHead = document.createElement('thead');
      const tableBody = document.createElement('tbody');

      // Crear la fila de encabezado
      const headerRow = document.createElement('tr');
      const descriptionHeader = document.createElement('th');
      descriptionHeader.textContent = 'Descripción';
      const costHeader = document.createElement('th');
      costHeader.textContent = 'Costo';
      const salePriceHeader = document.createElement('th');
      salePriceHeader.textContent = 'Precio de Venta';
      
      const stockHeader = document.createElement('th');
      stockHeader.textContent = 'Stock';

      const usuarioIdHeader = document.createElement('th');
      usuarioIdHeader.textContent = 'Id Usuario';
      
      const actionsHeader = document.createElement('th');
      actionsHeader.textContent = 'Acciones';

      headerRow.appendChild(descriptionHeader);
      headerRow.appendChild(descriptionHeader);
      headerRow.appendChild(costHeader);
      headerRow.appendChild(salePriceHeader);
      headerRow.appendChild(stockHeader);
      headerRow.appendChild(usuarioIdHeader);
      headerRow.appendChild(actionsHeader);
      tableHead.appendChild(headerRow);

      // Crear las filas de datos
      data.forEach(product => {
        const row = document.createElement('tr');

        const descriptionCell = document.createElement('td');
        descriptionCell.textContent = product.descripcion;
        
        const costCell = document.createElement('td');
        costCell.textContent = `$${product.costo}`;
        
        const salePriceCell = document.createElement('td');
        salePriceCell.textContent = `$${product.precioVenta}`;
        
        const stockCell = document.createElement('td');
        stockCell.textContent = `${product.stock}`;

        const usuarioIdCell = document.createElement('td');
        usuarioIdCell.textContent = `${product.idUsuario}`;

        const actionsCell = document.createElement('td');

        // Agregar botones de acciones (Editar, Eliminar, etc.)
        const editButton = document.createElement('button');
        editButton.textContent = 'Editar';
        editButton.addEventListener('click', () => openEditModal(product));

        function openEditModal(product) {
            // Cargar los datos del producto en el formulario
            document.getElementById('id').value = product.id;
            document.getElementById('name').value = product.descripcion;
            document.getElementById('price').value = product.costo;
            document.getElementById('precio-venta').value = product.precioVenta;
            document.getElementById('id-usuario').value = product.idUsuario;
          
            // Mostrar el modal
            modal.style.display = 'block';
        }

        const deleteButton = document.createElement('button');
        deleteButton.textContent = 'Eliminar';
        deleteButton.addEventListener('click', () => deleteProduct(product.id));

        actionsCell.appendChild(editButton);
        actionsCell.appendChild(deleteButton);

        row.appendChild(descriptionCell);
        row.appendChild(costCell);
        row.appendChild(salePriceCell);
        row.appendChild(stockCell);
        row.appendChild(usuarioIdCell);
        row.appendChild(actionsCell);
        tableBody.appendChild(row);
      });

      productTable.appendChild(tableHead);
      productTable.appendChild(tableBody);
      contentArea.appendChild(productTable);
    })
    .catch(error => {
      console.error('Error fetching data:', error);
    });
}

  //Modal para edicion de producto
  // Selecciona el modal y los botones
const modal = document.getElementById("editModal");
const closeButton = document.getElementsByClassName("close-button")[0];
const cancelButton = document.getElementById("cancelButton");
const saveButton = document.getElementById("saveButton");
const editForm = document.getElementById("editForm");

// Función para abrir el modal y cargar los datos del producto
function openEditModal(product) {
  document.getElementById("id").value = product.id;
  document.getElementById("name").value = product.name;
  document.getElementById("price").value = product.price;
  modal.style.display = "block";
}

// Función para cerrar el modal sin guardar cambios
function closeModal() {
  modal.style.display = "none";
}

// Agrega los event listeners a los botones
closeButton.addEventListener("click", closeModal);
cancelButton.addEventListener("click", closeModal);

editForm.addEventListener("submit", (event) => {
  event.preventDefault();
  const formData = {
    id: document.getElementById("id").value,
    name: document.getElementById("name").value,
    price: document.getElementById("price").value,
    precioVenta: document.getElementById("precio-venta").value,
    idUsuario: document.getElementById("id-usuario").value,

  };
  // Enviar una solicitud de actualización al servidor
  saveProduct();
  
  console.log("Datos enviados al servidor:", formData);


  closeModal();
});
// Fin botones de modal de Productos

function saveProduct() {
    const id = document.getElementById('id').value;
    const name = document.getElementById('name').value;
    const price = document.getElementById('price').value;
    const salePrice = document.getElementById('precio-venta').value;
    const idUsuario = document.getElementById('id-usuario').value;

  
    const updatedProduct = {
      id: id,
      descripcion: name,
      costo: price,
      precioVenta: salePrice,
      idUsuario: idUsuario

    };
  
    //                             api/Producto/{id}/{descripcion}/{costo}/{precioVenta}/{idUsuario}
    fetch(`https://localhost:7214/api/producto/${id}/${name}/${price}/${salePrice}/${idUsuario}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(updatedProduct)
    })
    .then(response => {
      if (response.ok) {
        console.log('Producto actualizado correctamente');
        // Cerrar el modal y actualizar la tabla
        modal.style.display = 'none';
        showProductTable();
      } else {
        console.error('Error al actualizar el producto');
      }
    })
    .catch(error => {
      console.error('Error en la solicitud:', error);
    });
  }

  
  function deleteProduct(id) {
    return fetch(`https://localhost:7214/api/producto/${id}`, {
      method: 'DELETE',
    })
    .then(response => {
      if (response.ok) {
        console.log('Producto eliminado exitosamente');
        showProductTable();
        return true;
      } else {
        console.error('Error al eliminar el producto');
        return false;
      }
    })
    .catch(error => {
      console.error('Error al eliminar el producto:', error);
      return false;
    });
  }




//ProductoVendido

function showSoldProductTable() {
    // Código para mostrar la tabla de Productos Vendidos
    contentArea.innerHTML = ""; // Limpiar el área de contenido
  
    fetch("https://localhost:7214/api/productovendido")
      .then((response) => response.json())
      .then((data) => {
        const productTable = document.createElement("table");
        const tableHead = document.createElement("thead");
        const tableBody = document.createElement("tbody");
  
        // Crear la fila de encabezado
        const headerRow = document.createElement("tr");
  
        const idProductoHeader = document.createElement("th");
        idProductoHeader.textContent = "Id Producto";
  
        const stockHeader = document.createElement("th");
        stockHeader.textContent = "Stock";
  
        const IdVentaHeader = document.createElement("th");
        IdVentaHeader.textContent = "Id Venta";
  
        const actionsHeader = document.createElement("th");
        actionsHeader.textContent = "Acciones";
  
        headerRow.appendChild(idProductoHeader);
        headerRow.appendChild(stockHeader);
        headerRow.appendChild(IdVentaHeader);

        headerRow.appendChild(actionsHeader);
        tableHead.appendChild(headerRow);
  
        // Crear las filas de datos
        data.forEach((productV) => {
          const row = document.createElement("tr");
  
          const idProductoVCell = document.createElement("td");
          idProductoVCell.textContent = productV.idProducto;
  
          const stockPVCell = document.createElement("td");
          stockPVCell.textContent = `${productV.stock}`;
  
          const idVentaPVCell = document.createElement("td");
          idVentaPVCell.textContent = `${productV.idVenta}`;
  
          const actionsCellPV = document.createElement("td");
  
          // Agregar botones de acciones (Editar, Eliminar, etc.)
          const editButtonPV = document.createElement("button");
          editButtonPV.textContent = "Editar";
          editButtonPV.addEventListener("click", () => openEditModalPV(productV));
  
          function openEditModalPV(productV) {
            // Cargar los datos del producto en el formulario
            document.getElementById("idPV").value = productV.id;
            document.getElementById("idProductoV").value = productV.idProducto;
            document.getElementById("stockPV").value = productV.stock;
            document.getElementById("idVentaPV").value = productV.idVenta;
  
            // Mostrar el modal
            modalPV.style.display = "block";
          }
  
          const deleteButtonPV = document.createElement("button");
          deleteButtonPV.textContent = "Eliminar";
          deleteButtonPV.addEventListener("click", () => deleteProductV(product.id));
  
          actionsCell.appendChild(editButtonPV);
          actionsCell.appendChild(deleteButtonPV);
  
          row.appendChild(idProductoVCell);
          row.appendChild(stockPVCell);
          row.appendChild(idVentaPVCell);
  
          row.appendChild(actionsCellPV);
          tableBody.appendChild(row);
        });
  
        productTable.appendChild(tableHead);
        productTable.appendChild(tableBody);
        contentArea.appendChild(productTable);
      })
      .catch((error) => {
        console.error("Error fetching data:", error);
      });
  }
  
  //Accionnes de ProductoVendido
  
  //Modal para edicion de producto
  // Selecciona el modal y los botones
  const modalPV = document.getElementById("editModalPV");
  const closeButtonPV = document.getElementsByClassName("close-button")[0];
  const cancelButtonPV = document.getElementById("cancelButton");
  const saveButtonPV = document.getElementById("saveButton");
  const editFormPV = document.getElementById("editForm");
  
  // Función para abrir el modal y cargar los datos del producto
  function openEditModalPV(productoVendido) {
    document.getElementById("id").value = productoVendido.id;
    document.getElementById("id-producto").value = productoVendido.idProducto;
    document.getElementById("stock").value = productoVendido.stock;
    document.getElementById("id-venta").value = productoVendido.idVenta;
  
    modalPV.style.display = "block";
  }
  
  // Función para cerrar el modal sin guardar cambios
  function closeModalPV() {
    modal.style.display = "none";
  }
  
  // Agrega los event listeners a los botones
  closeButtonPV.addEventListener("click", closeModalPV);
  cancelButtonPV.addEventListener("click", closeModalPV);
  
  editFormPV.addEventListener("submit", (event) => {
    event.preventDefault();
    const formDataPV = {
      id: document.getElementById("idPV").value,
      idProducto: document.getElementById("idProductoV").value,
      stock: document.getElementById("stockPV").value,
      idVenta: document.getElementById("idVentaPV").value,
    };
    // Aquí deberías enviar una solicitud de actualización al servidor con los datos modificados
    saveProductV();
  
    console.log("Datos enviados al servidor:", formDataPV);
  
    closeModalPV();
  });
  // Fin botones de modal de Productos
  
  function saveProductV() {
    const idPV = document.getElementById("idPV").value;
    const idProductoV = document.getElementById("idProductoV").value;
    const stockPV = document.getElementById("stockPV").value;
    const idVentaPV = document.getElementById("idVentaPV").value;
  
    const updatedProductV = {
      idPV: idPV,
      idProducto: idProductoV,
      stock: stockPV,
      idVenta: idVentaPV
    };
  
    //                             api/Producto/{id}/{descripcion}/{costo}/{precioVenta}/{idUsuario}
    fetch(
      `https://localhost:7214/api/productovendido/${idPV}/${idProducto}/${stock}/${idVenta}`,
      {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(updatedProductV),
      }
    )
      .then((response) => {
        if (response.ok) {
          console.log("Producto Vendido actualizado correctamente");
          // Cerrar el modal y actualizar la tabla
          modal.style.display = "none";
          showProductTable();
        } else {
          console.error("Error al actualizar el Producto Vendido");
        }
      })
      .catch((error) => {
        console.error("Error en la solicitud 'PUT' a Producto Vendido:", error);
      });
  }
  
  function deleteProductV(id) {
    return fetch(`https://localhost:7214/api/productovendido/${id}`, {
      method: "DELETE",
    })
      .then((response) => {
        if (response.ok) {
          console.log("Producto Vendido eliminado exitosamente");
          showProductTable();
          return true;
        } else {
          console.error("Error al eliminar el Producto Vendido");
          return false;
        }
      })
      .catch((error) => {
        console.error("Error al eliminar el Producto Vendido:", error);
        return false;
      });
  }


// Resto de metodos de cada tabla















function showUserTable() {
  // Código para mostrar la tabla de Usuarios
}

function showSaleTable() {
  // Código para mostrar la tabla de Ventas
}

