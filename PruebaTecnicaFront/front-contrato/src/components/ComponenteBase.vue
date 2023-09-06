<template>
  <div class="container">
      <div class="row">
          <div class="col-md-3">
              <ComponenteA @enviarIdContrato="cargarContrato" />
          </div>
          <div class="col">
              <ComponenteB :contrato="contrato" :cargando="cargando"/>
          </div>
      </div>
  </div>
</template>
  
<script>
import ComponenteA from './ComponenteA.vue';
import ComponenteB from './ComponenteB.vue';
import { ContratoService } from '@/services/ContratoService';

export default {
  components: {
    ComponenteA,
    ComponenteB,
  },
  data() {
    return {
      contrato: null,
      cargando: false,
    };
  },
  methods: {
    async cargarContrato(contratoId) {
    if (contratoId) {
      this.cargando = true;
      try {
        const response = await ContratoService.getContrato(contratoId);
        this.contrato = response.data;
      } catch (error) {
        this.contrato = null;
      } finally {
        this.cargando = false;
      }
    } else {
      this.contrato = null;
      }
    },
  },
};
</script>
