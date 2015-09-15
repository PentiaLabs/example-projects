require.config({
	waitSeconds: 45,
	paths: {
		'requirejs': 'require',
		'loader': 'common/loader',
		'facade': 'common/facade',
		'mediator': 'common/mediator',
		'jquery': 'common/jquery.min'
	}
});

// execute our loader immediately
require(['facade', 'loader'], function (facade) {
	facade.publish('loader:refresh');
});


// load famework things
require(['framework/floatlabels/main','framework/forms/main'], function (facade) {
});