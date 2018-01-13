var path = require('path');
var webpack = require('webpack');

module.exports = function (env) {

    env = env || {};
    var isProd = env.NODE_ENV === 'production';

    var config = {
        entry: {
            main: './wwwroot/js/main'
        },
        output: {
            path: path.join(__dirname, 'wwwroot/dist'),
            filename: '[name].js'
        },
        devtool: 'eval-source-map',
        resolve: {
            extensions: ['.ts', '.tsx', '.js', '.jsx']
        },
        plugins: [
            new webpack.ProvidePlugin({ $: 'jquery', jQuery: 'jquery', jquery: 'jquery' })
        ],
        module: {
            rules: [
                { test: /\.css?$/, use: ['style-loader', 'css-loader'] },
                { test: /\.(png|jpg|jpeg|gif|svg)$/, use: 'url-loader?limit=25000' },
                { test: /\.(png|woff|woff2|eot|ttf|svg)(\?|$)/, use: 'url-loader?limit=100000' }
            ]
        }
    };

  
    if (isProd) {
        config.devtool = 'source-map';
        config.plugins = config.plugins.concat([
            new webpack.optimize.UglifyJsPlugin({
                sourceMap: false
            })
        ]);
    }

    return config;
};