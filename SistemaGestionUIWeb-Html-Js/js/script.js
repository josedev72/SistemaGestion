// script.js
const productNavLink = document.getElementById('product-nav');
const soldProductNavLink = document.getElementById('sold-product-nav');
const userNavLink = document.getElementById('user-nav');
const saleNavLink = document.getElementById('sale-nav');
const contentArea = document.getElementById('content-area');

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
      const actionsHeader = document.createElement('th');
      actionsHeader.textContent = 'Acciones';

      headerRow.appendChild(descriptionHeader);
      headerRow.appendChild(costHeader);
      headerRow.appendChild(salePriceHeader);
      headerRow.appendChild(stockHeader);
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
        stockCell.textContent = product.stock;
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

function editProduct(id) {
    // Hacer la llamada a la API para actualizar el producto
    fetch(`https://localhost:7214/api/producto/${id}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({
        // Datos actualizados del producto
        descripcion: 'Nuevo nombre del producto',
        costo: 25.99,
        precioVenta: 39.99,
        stock: 50
      })
    })
    .then(response => {
      if (response.ok) {
        console.log('Producto actualizado exitosamente');
        showProductTable(); // Actualizar la tabla de productos
      } else {
        console.error('Error al actualizar el producto');
      }
    })
    .catch(error => {
      console.error('Error al actualizar el producto:', error);
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
  };
  // Aquí deberías enviar una solicitud de actualización al servidor con los datos modificados
  console.log("Datos enviados al servidor:", formData);
  closeModal();
});
// Fin botones de modal de Productos



  
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











// Resto de metodos de cada tabla

function showSoldProductTable() {
  // Código para mostrar la tabla de Productos Vendidos
}

function showUserTable() {
  // Código para mostrar la tabla de Usuarios
}

function showSaleTable() {
  // Código para mostrar la tabla de Ventas
}

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