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