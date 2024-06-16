fetch('https://localhost:7214/api/producto')
.then(response => response.json())
.then(data => {
  const productList = document.getElementById('product-list');

  data.forEach(product => {
    const productElement = document.createElement('div');
    productElement.classList.add('product');

    //cabecera de producto
    const descriptionElement = document.createElement('h3');
    descriptionElement.textContent = product.descripcion;

    //Campos subsiguientes
    const costElement = document.createElement('p');
    costElement.textContent = `Costo: $${product.costo}`;

    const salePriceElement = document.createElement('p');
    salePriceElement.textContent = `Precio de venta: $${product.precioVenta}`;

    const stockElement = document.createElement('p');
    stockElement.textContent = `Stock: ${product.stock}`;

    const idUsuarioElement = document.createElement('p');
    idUsuarioElement.textContent = `Id Usuario: ${product.idUsuario}`;

    productElement.appendChild(descriptionElement);
    productElement.appendChild(costElement);
    productElement.appendChild(salePriceElement);
    productElement.appendChild(stockElement);
    productElement.appendChild(idUsuarioElement);

    productList.appendChild(productElement);
  });
})
.catch(error => {
  console.error('Error fetching data:', error);
});