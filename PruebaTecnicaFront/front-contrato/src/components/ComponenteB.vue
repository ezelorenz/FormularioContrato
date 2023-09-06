<template>
  <div>
    <div v-if="cargando">
      <p>Cargando...</p>
    </div>
    <div v-if="contrato !== null && !error">
      <ul class="list-group">
        <h2>Detalle del Contrato</h2>
        <li class="list-group-item">Código del Curso: {{ contrato.courseCode }}</li>
        <li class="list-group-item">Fecha de Alta: {{ contrato.fechaAlta }}</li>
        <li class="list-group-item">Colegio Nivel: {{ contrato.colegioNivel }}</li>
        <li class="list-group-item">Nombre del Colegio: {{ contrato.colegioNombre }}</li>
        <li class="list-group-item">Curso del Colegio: {{ contrato.colegioCurso }}</li>
        <li class="list-group-item">Localidad del Colegio: {{ contrato.colegioLocalidad }}</li>
        <li class="list-group-item">
          <h4>Pedidos</h4>
          <ul class="list-group">
            <li class="list-group-item" v-for="(pedido, index) in contrato.pedidos" :key="index">
              <div>
                Cantidad: {{ pedido.cantidadEgresados }}
              </div>
              <div>
                Articulo: {{ pedido.articulo }}
              </div>
              <div>
                Precio Unitario: ${{ pedido.precioUnitario }}
              </div>
              <div>
                Total: ${{ pedido.totalArticulo }}
              </div>
            </li>
          </ul>
        </li>
        <li class="list-group-item">Total: ${{ contrato.total }}</li>
        <li class="list-group-item">Fecha de Entrega: {{ contrato.fechaEntrega }}</li>
      </ul>
    </div>
    <div v-else>
      <p v-if="!error"></p>
      <p v-else>No se encontró ningún contrato.</p>
    </div>
  </div>
</template>
  
<script>
    export default {
    name: "ComponenteB",
    props: ["contrato", "cargando"],
    data() {
      return {
        error: null,
      };
    },
    watch: {
      contrato(newValue) {
        if (!newValue) {
          this.error = true;
        } else {
          this.error = false;
        }
      },
    },
  };
  </script>
  