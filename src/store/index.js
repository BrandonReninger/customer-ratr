import Vue from 'vue'
import Vuex from 'vuex'
import Axios from 'axios'
import router from "../router"

Vue.use(Vuex)

let baseUrl = location.host.includes("localhost") ?
  "https://localhost:5001/" :
  "/";

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 3000,
  withCredentials: true
});

export default new Vuex.Store({
  state: {
    customers: []
  },
  mutations: {
    setCustomers(state, customers) {
      state.customers = customers
    }
  },
  actions: {
    async getCustomers({
      commit
    }) {
      try {
        let res = await api.get('customers')
        commit('setCustomers', res.data)
      } catch (error) {
        console.error(error)
      }
    }
  },
})