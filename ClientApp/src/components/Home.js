import React, { Component } from 'react';

// import ApexCharts from 'apexcharts';


export class Home extends Component {
  static displayName = Home.name;
  render () {
    return (
      <div id="chart">
        <ApexChart></ApexChart>
      </div>
    );
  }
}
