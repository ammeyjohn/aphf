import './vendor.js';
import './metronic.js';

// Vue
import Vue from 'vue';
import VueRouter from 'vue-router';
import Vuex from 'vuex';
import axios from 'axios';

import Layout from 'frontend/layout/scripts/layout.js';

// Components
import MenuBar from './app/menubar.vue';
import Slider from './app/slider.vue';
import PreFooter from './app/prefooter.vue';

Vue.use(VueRouter);
Vue.use(Vuex);

// Define router
const router = new VueRouter({
    routes: [{
        path: '/',
        name: 'root'
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
        MenuBar,
        Slider,
        PreFooter
    },
    mounted() {
        Layout.init();
        document.title = '第12届亚太口琴节';


    }
});