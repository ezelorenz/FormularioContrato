<template>
  <div class="container mt-3">
    <div class="grid">
      <div class="row">
            <div class="col">
                <p class="h3 text-success fw-bold">Buscador de Contrato</p>
                <p class="fst-italic">En la siguiente aplicación deberá ingresar el Id del contrato que desee buscar.</p>
                <ComponenteBase/> 
            </div>
        </div>
    </div>  
  </div>
  
</template>

<script>
import ComponenteBase from '@/components/ComponenteBase.vue'

export default {
  name: 'HomeView',
  components: { ComponenteBase }
}
</script>
