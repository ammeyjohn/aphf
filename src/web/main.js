// Vue
import Vue from 'vue';
import VueRouter from 'vue-router';
import Vuex from 'vuex';
import axios from 'axios';

import Layout from 'frontend/layout/scripts/layout.js';

// Components
import MenuBar from './app/header.vue';

Vue.use(VueRouter);
Vue.use(Vuex);

// Define router
const router = new VueRouter({
    routes: [{
        path: '/',
        name: 'root',
        redirect: '/demo'
    }]
});

// Define store
const store = new Vuex.Store({
    state: {

    }
});

new Vue({
    el: '#app',
    router: router,
    store: store,
    // render: h => h(App)
    components: {
        MenuBar
    },
    mounted() {

        Layout.init();

        document.title = '第12届亚太口琴节';
    }
});