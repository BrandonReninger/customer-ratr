<template>
  <div class="customers">
    <div class="card" style="width: 18rem;">
      <img :src="customer.img" class="card-img-top" alt="customer pic" />
      <div class="card-body">
        <h5 class="card-title">{{customer.name}}</h5>
        <p class="card-text">{{customer.description}}</p>
      </div>
      <ul class="list-group list-group-flush">
        <li class="list-group-item">{{customer.rating}}/5</li>
        <li class="list-group-item">{{customer.likes}}</li>
        <li class="list-group-item">{{customer.unhinged}}</li>
      </ul>
    </div>
  </div>
</template>


<script>
export default {
  name: "customers",
  data() {
    return {};
  },
  computed: {},
  methods: {},
  components: {}
};
</script>


<style scoped>
</style>