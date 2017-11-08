'use strict';

const path = require('path');
const webpack = require('webpack');
const ExtractTextPlugin = require('extract-text-webpack-plugin');
const HtmlWebpackPlugin = require('html-webpack-plugin');

module.exports = {
    entry: {
        vendor: './src/web/vendor.js',
        metronic: './src/web/metronic.js',
        main: './src/web/main.js',
        // vue: [
        //     'vue',
        //     'vue-router',
        //     'vuex',
        //     'axios',
        // ]
    },
    output: {
        path: path.resolve(__dirname, 'dist'),
        publicPath: '/',
        filename: 'js/[name].js',
        chunkFilename: 'js/[name].chunk.js'
    },
    module: {
        rules: [{
            test: /\.js$/,
            include: [path.resolve(__dirname, 'src')],
            use: {
                loader: 'babel-loader',
                options: {
                    presets: ['env']
                }
            }
        }, {
            test: /\.css$/,
            use: ExtractTextPlugin.extract({
                use: ['css-loader?minimize'],
                fallback: 'style-loader'
            })
        }, {
            test: /\.(html)$/,
            loader: 'html-loader'
        }, {
            test: /\.(png|jpe?g|gif|svg)(\?.*)?$/,
            use: [{
                loader: 'url-loader',
                options: {
                    limit: 10240,
                    name: 'assets/images/[name].[ext]'
                }
            }]
        }, {
            test: /\.(woff2?|eot|ttf|otf)(\?.*)?$/,
            use: [{
                loader: 'url-loader',
                options: {
                    limit: 10240,
                    name: 'assets/fonts/[name].[ext]'
                }
            }]
        }]
    },
    plugins: [
        new ExtractTextPlugin({
            filename: 'css/[name].css',
            allChunks: true
        }),
        new HtmlWebpackPlugin({
            filename: 'index.html',
            template: './src/web/index.html'
        }),
        new webpack.ProvidePlugin({
            $: "jquery",
            jQuery: "jquery"
        })
    ],
    resolve: {
        extensions: ['.js', '.vue', '.css', '.scss'],
        modules: [
            path.resolve(__dirname, 'src/web'),
            path.resolve(__dirname, 'src/web/assets'),
            'node_modules'
        ],
        alias: {
            'vue': 'vue/dist/vue.common',
            'jquery': 'jquery'
        }
    },
    devtool: 'inline-source-map',
    devServer: {
        contentBase: path.resolve(__dirname, 'dist'),
        inline: true,
        historyApiFallback: true
    }
}