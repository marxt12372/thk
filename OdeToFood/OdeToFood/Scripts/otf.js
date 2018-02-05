$(function ()
{
	function ajaxFormSubmit()
	{
		var $form = $(this);

		var options = {
			url: $form.attr("action"),
			type: $form.attr("method"),
			data: $form.serialize()
		};

		$.ajax(options).done(function (data) {
			var $target = $($form.attr("data-otf-target"));
			var $newhtml = $(data);
			$target.replaceWith($newhtml);
			$newhtml.effect("highlight");
			$target.highlight();
		});

		return false;
	}

	function selectAutocompleteItem(event, ui)
	{
		var $input = $(this);
		$input.val(ui.item.label);

		var $form = $input.parents("form:first");
		$form.submit();
	}

	function autoCompleteAction()
	{
		var $input = $(this);

		var options = {
			source: $input.attr("data-otf-autocomplete"),
			select: selectAutocompleteItem
		};

		$input.autocomplete(options);
	}

	$("form[data-otf-ajax='true']").submit(ajaxFormSubmit);
	$("input[data-otf-autocomplete]").each(autoCompleteAction);
});