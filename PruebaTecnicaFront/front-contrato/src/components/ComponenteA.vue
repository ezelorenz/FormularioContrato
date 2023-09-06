<template>
  <div class="card shadow-lg">
      <div class="card-header bg-success text-white">
          <p class="h3">Buscador</p>
      </div>
      <div class="card-body bg-light">
          <form @submit.prevent="enviarId">
              <div class="mb-2">
                  <input v-model="contratoId" type="number" min="1" placeholder="Ingrese el Id del contrato">
              </div>
              <div class="mb-2">
                <button class="btn btn-success">Enviar</button>
              </div>
          </form>
      </div>
  </div>
</template>
  
<script>
export default {
  data() {
    return {
      contratoId: null,
    };
  },
  methods: {
    enviarId(){
      this.$emit("enviarIdContrato", this.contratoId);
    }
  },
};
</script>
  