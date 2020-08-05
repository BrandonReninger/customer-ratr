<template>
  <div class="profile">
    <div class="card" style="width: 18rem;">
      <img :src="profile.image" class="card-img-top" alt="..." />
      <div class="card-body">
        <h5 class="card-title">{{profile.name}}</h5>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "profile",
  data() {
    return {};
  },
  mounted() {
    this.$store.dispatch("getUser");
  },
  computed: {
    profile() {
      this.$store.state.activeUser;
    }
  },
  methods: {},
  components: {}
};
</script>


<style scoped>
</style>