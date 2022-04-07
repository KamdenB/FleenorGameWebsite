import React, { Component } from 'react';
import { Alert } from 'reactstrap';

export class NotFound extends Component {
  render () {
    return (
      <div>
        <Alert color="danger">
          <h4 className="alert-heading">404</h4>
          <p>Page not found.</p>
        </Alert>
      </div>
    );
  }
}