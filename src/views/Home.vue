<template>
  <div class="home">
    <h1>CustomerRatr</h1>
    <div class="row justify-content-center">
      <create-customer></create-customer>
    </div>
    <div class="row">
      <customers v-for="customer in customers" :key="customer.id" :customerData="customer"></customers>
    </div>
  </div>
</template>

<script>
import Customers from "../components/Customers.vue";
import CreateCustomer from "../components/CreateCustomer.vue";
export default {
  name: "Home",
  mounted() {
    this.$store.dispatch("getCustomers");
  },
  computed: {
    customers() {
      return this.$store.state.customers;
    }
  },
  components: { Customers, CreateCustomer }
};
</script>
