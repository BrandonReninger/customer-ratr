<template>
  <div class="customers col-4">
    <div class="card" style="width: 18rem;">
      <img :src="customerData.img" class="card-img-top" alt="customer pic" />
      <div class="card-body">
        <h5 class="card-title">{{customerData.name}}</h5>
        <p class="card-text">{{customerData.description}}</p>
      </div>
      <ul class="list-group list-group-flush">
        <li class="list-group-item">{{customerData.rating}}/5</li>
        <li class="list-group-item">{{customerData.likes}}</li>
        <li class="list-group-item">{{customerData.unhinged}}</li>
      </ul>
    </div>
  </div>
</template>


<script>
export default {
  name: "customers",
  props: ["customerData"],
  data() {
    return {};
  },
  mounted() {
    this.$store.dispatch("getCustomers");
  },
  computed: {},
  methods: {},
  components: {}
};
</script>


<style scoped>
</style>