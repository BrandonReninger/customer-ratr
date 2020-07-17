<template>
  <div class="create-customer">
    <!-- pop this up at click -->
    <form @submit.prevent="createCustomer()">
      <div class="form-group">
        <label for="name">Name:</label>
        <input
          type="text"
          name="name"
          class="form-control"
          placeholder="enter name..."
          v-model="newCustomer.name"
        />
      </div>
      <div class="form-group">
        <label for="img">Image Url:</label>
        <input
          type="text"
          name="img"
          class="form-control"
          placeholder="paste image url..."
          v-model="newCustomer.img"
        />
      </div>
      <div class="form-group">
        <label for="rating">Rating:</label>
        <input
          type="number"
          min="0"
          max="5"
          name="rating"
          class="form-control"
          placeholder="enter rating..."
          v-model="newCustomer.rating"
        />
      </div>
      <div class="form-group">
        <label for="unhinged">Unhinged?</label>
        <input type="checkbox" name="unhinged" class="form-control" v-model="newCustomer.unhinged" />
      </div>
      <div class="form-group">
        <label for="likes">Friendly?</label>
        <input
          type="text"
          name="likes"
          class="form-control"
          placeholder="Yes or No..."
          v-model="newCustomer.likes"
        />
      </div>
      <div class="form-group">
        <label for="description">Description</label>
        <input
          type="text"
          name="description"
          class="form-control"
          v-model="newCustomer.description"
        />
      </div>

      <button class="btn btn-primary" type="submit">SUBMIT</button>
    </form>
  </div>
</template>


<script>
export default {
  name: "create-customer",
  data() {
    return {
      newCustomer: {}
    };
  },
  computed: {},
  methods: {
    createCustomer() {
      this.$store.dispatch("createCustomer", this.newCustomer);
    }
  },
  components: {}
};
</script>


<style scoped>
</style>