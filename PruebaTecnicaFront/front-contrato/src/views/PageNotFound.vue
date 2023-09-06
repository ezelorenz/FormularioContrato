<template>
    <div class="container text-center mt-3">
        <div class="row">
            <div class="col">
                <h2 class="text-danger">404! Page Not Found</h2>
                <router-link to="/">
                    <button class="btn btn-success">Volver a la página de inicio</button>
                </router-link>
            </div>                
        </div>
    </div>
    
</template>

<script>


export default {
    name: "PageNotFound",
}
</script>