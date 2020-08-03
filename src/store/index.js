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
    customers: [],
    users: [],
    activeUser: {}
  },
  mutations: {
    setCustomers(state, customers) {
      state.customers = customers
    },
    setActiveUser(state, activeUser) {
      state.activeUser = activeUser
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
    },

    async getUser({
      commit
    }, id) {
      try {
        let res = await api.get('users' + id)
        commit('setUser', res.data)
      } catch (error) {
        console.error(error)
      }
    },

    async createCustomer({
      dispatch
    }, newCustomer) {
      try {
        let res = await api.post('customers', newCustomer)
        dispatch('getCustomers')
      } catch (error) {
        console.error(error)
      }
    },

    async createUser({
      dispatch
    }, newUser) {
      try {
        debugger
        let res = await api.post('users', newUser)
        dispatch('getUser')
      } catch (error) {
        console.error(error)
      }
    }

  }

})