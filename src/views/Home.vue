<template>
  <div class="home">
    <h1>CustomerRatr</h1>
    <div>
      <h3>New to judging people? Click below to sign up!</h3>
      <button
        type="button"
        class="btn btn-primary"
        data-toggle="modal"
        data-target="#joinModal"
      >JOIN NOW!</button>
    </div>

    <div
      class="modal fade"
      id="joinModal"
      tabindex="-1"
      role="dialog"
      aria-labelledby="exampleModalLabel"
      aria-hidden="true"
    >
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Just a little info</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            <form @submit="createUser()">
              <div class="form-group">
                <label for="userName">Username:</label>
                <input
                  type="text"
                  name="userName"
                  class="form-control"
                  placeholder="enter username..."
                  v-model="newUser.name"
                />
              </div>
              <div class="form-group">
                <label for="password">Password:</label>
                <input
                  type="password"
                  name="password"
                  class="form-control"
                  placeholder="enter a good password..."
                  v-model="newUser.password"
                />
              </div>
              <div class="form-group">
                <label for="image">Image Url:</label>
                <input
                  type="text"
                  name="image"
                  class="form-control"
                  placeholder="paste image url..."
                  v-model="newUser.image"
                />
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                <button type="submit" class="btn btn-primary">Save changes</button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>

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
  data() {
    return {
      newUser: {}
    };
  },
  mounted() {
    this.$store.dispatch("getCustomers");
  },
  computed: {
    customers() {
      return this.$store.state.customers;
    }
  },
  methods: {
    createUser() {
      return this.$store.dispatch("createUser", this.newUser);
      this.newUser = {};
    }
  },
  components: { Customers, CreateCustomer }
};
</script>
