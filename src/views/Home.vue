<template>
  <div class="home">
    <h1>CustomerRatr</h1>
    <div class="row">
      <customers v-for="customer in customers" :key="customer.id" :customerData="customer"></customers>
    </div>
  </div>
</template>

<script>
import Customers from "../components/Customers.vue";
export default {
  name: "Home",
  components: { Customers }
};
</script>
